

-- ------------------- HrManagement ---------------
-- Date 2015/10/10
-- ---------------------- 建表 -------------
use `hrmanagement`;

-- 薪资表
drop table if exists `salary`;
CREATE TABLE `hrmanagement`.`salary` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `EmployeeId` INT NOT NULL,
  `PreSalary` DECIMAL(8,2) NOT NULL DEFAULT 0,
  `NetSalary` DECIMAL(8,2) NOT NULL DEFAULT 0,
  `Month` VARCHAR(6) NOT NULL,
  `GrantTime` DATETIME NOT NULL,
  PRIMARY KEY (`Id`)
)
COMMENT = '工资表';


-- 税率表
drop table if exists `TaxRate`;
create table `hrmanagement`.`TaxRate`(
    `Id` int not null auto_increment, 
    `TaxThreshold` decimal(8,2) not null comment '个税起征点',
    `MedicalRateP` decimal(4,3) not null comment '医疗保险-个人',
    `MedicalRateC` decimal(4,3) not null comment '医疗保险-公司',
    `EndowmentRateP` decimal(4,3) not null comment '养老保险-个人',   
    `EndowmentRateC` decimal(4,3) not null comment '养老保险-公司',
    `UnemploymentRateP` decimal(4,3) not null comment '失业保险-个人',
    `UnemploymentRateC` decimal(4,3) not null comment '失业保险-公司',
    `AccidentRateP` decimal(4,3) not null comment '工伤保险-个人',   
    `AccidentRateC` decimal(4,3) not null comment '工伤保险-公司',   
    `MaternityRateP` decimal(4,3) not null comment '生育保险-个人',      
    `MaternityRateC` decimal(4,3) not null comment '生育保险-公司',      
    `FundP` decimal(4,3) not null comment '公积金-个人',   
    `FundC` decimal(4,3) not null comment '公积金-公司',   
	PRIMARY KEY (`Id`)
)
COMMENT = '税率表';

-- ---------------------- 创建索引，提高效率 -------
create index `Salary_Month_Idx` on `Salary`(`Month`);


-- ---------------------- 初始化数据 -------------
-- 批量写入薪资表存储过程
delimiter $$
drop procedure if exists `InsertSalaryBatch` $$
create procedure `InsertSalaryBatcrateh`(count int, month varchar(6))
begin
	declare i int default 1;
	while i< count do
		insert into salary(`EmployeeId`,`PreSalary`,`Month`,`GrantTime`) 
			values(i, ( 3000 + (i%500 + (i*i%9)*1000)),month,now());
		set i = i + 1;
	end while;
end$$



-- 计算税后工资的动作写在一个存储过程中
-- 只支持 按月 的重计算
delimiter ///
drop procedure if exists `CalcNetSalary` ///
create procedure `CalcNetSalary`(ids varchar(1000)) 
begin

	-- 中间计算变量应纳税额
	declare rate decimal(8,2) default 0; -- 5险1金的税额
    declare TaxThreshold decimal(8,2);	-- 缴税阀值
    declare MedicalRateP,EndowmentRateP,UnemploymentRateP,AccidentRateP,MaternityRateP,FundP decimal(4,3); 
        
	-- calc here.     
	select t.TaxThreshold, t.MedicalRateP, t.EndowmentRateP, t.UnemploymentRateP, t.AccidentRateP, t.MaternityRateP, t.FundP 
		into TaxThreshold, MedicalRateP,EndowmentRateP,UnemploymentRateP,AccidentRateP,MaternityRateP,FundP 
		from `TaxRate` t where id = 1;
        
	set rate = (MedicalRateP + EndowmentRateP + UnemploymentRateP + AccidentRateP + MaternityRateP + FundP);
    
    update `salary` a set `NetSalary` = (
		case when (a.preSalary - (a.preSalary * rate) - TaxThreshold) <=0 then a.preSalary - (a.preSalary * rate) 
        when (a.preSalary - (a.preSalary * rate) - TaxThreshold) <=1500 then a.preSalary - (a.preSalary * rate) - (a.preSalary - (a.preSalary * rate) - TaxThreshold) *  0.03 
        when (a.preSalary - (a.preSalary * rate) - TaxThreshold) <=4500 then a.preSalary - (a.preSalary * rate) - (a.preSalary - (a.preSalary * rate) - TaxThreshold) *  0.1 - 105 
        when (a.preSalary - (a.preSalary * rate) - TaxThreshold) <=9000 then a.preSalary - (a.preSalary * rate) - (a.preSalary - (a.preSalary * rate) - TaxThreshold) *  0.2 - 555 
        when (a.preSalary - (a.preSalary * rate) - TaxThreshold) <=35000 then a.preSalary - (a.preSalary * rate) - (a.preSalary - (a.preSalary * rate) - TaxThreshold) *  0.25 - 1005 
        when (a.preSalary - (a.preSalary * rate) - TaxThreshold) <=55000 then a.preSalary - (a.preSalary * rate) - (a.preSalary - (a.preSalary * rate) - TaxThreshold) *  0.3 - 2755 
        when (a.preSalary - (a.preSalary * rate) - TaxThreshold) <=80000 then a.preSalary - (a.preSalary * rate) - (a.preSalary - (a.preSalary * rate) - TaxThreshold) *  0.35 - 5505
        else a.preSalary - (a.preSalary * rate) - (a.preSalary - (a.preSalary * rate) - TaxThreshold) *  0.45 - 13505 end
	) where a.`Id` > 0 and ( case when ids <> '' then find_in_set(a.`Id`, ids) else 1 =1 end);
    
END /// 


call CalcNetSalary('');


select * from Salary ;















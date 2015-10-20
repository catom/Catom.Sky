

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


-- ---------------------- 初始化数据 -------------
-- 批量写入薪资表存储过程
delimiter $$
drop procedure if exists `InsertSalaryBatch` $$
create procedure `InsertSalaryBatch`(count int, month varchar(6))
begin
	declare i int default 1;
	while i< count do
		insert into salary(`EmployeeId`,`PreSalary`,`Month`,`GrantTime`) 
			values(i, ( 3000 + (i%500 + (i*i%9)*1000)),month,now());
		set i = i + 1;
	end while;
end
$$



-- 获取税率
delimiter /$
drop function if exists `GetRate` /$
create function `GetRate`(Thre int out) returns decimal(4,3)
begin    
    declare MedicalRateP,EndowmentRateP,UnemploymentRateP,AccidentRateP,MaternityRateP,FundP decimal(4,3);
    
    select t.MedicalRateP, t.EndowmentRateP, t.UnemploymentRateP, t.AccidentRateP, t.MaternityRateP, t.FundP 
		into MedicalRateP,EndowmentRateP,UnemploymentRateP,AccidentRateP,MaternityRateP,FundP 
        from `TaxRate` t where id = 1;
	return (MedicalRateP + EndowmentRateP + UnemploymentRateP + AccidentRateP + MaternityRateP + FundP);
end /$
    

-- 实发工资计算函数
delimiter //
drop function if exists `CalcNetSalary` //
create function `CalcNetSalary`(preSalary decimal(8,2), TaxThreshold decimal(8,2)) returns decimal(8,2)
begin
	declare result decimal(8,2) default 0;
    declare should decimal default 0;	
	declare rs1 decimal(8,2) default 0; -- 1. 先减去5险1金
    
	set rs1 = preSalary * GetRate();
    
    -- 2. 减去扣除数,得到可纳税额度
    set should = preSalary - rs1 - TaxThreshold;
    
    -- 3. 可纳税额 乘以 税率 - 前阶段全纳税额
    if should <= 0 then
		set result = preSalary - rs1;        
    elseif should <= 1500 then
		set result = preSalary - rs1 - should *  0.03;
    elseif should <= 4500 then
		set result = preSalary - rs1 - should *  0.1 - 105;
    elseif should <= 9000 then
		set result = preSalary - rs1 - should *  0.2 - 555;
    elseif should <= 35000 then
		set result = preSalary - rs1 - should *  0.25 - 1005;
    elseif should <= 55000 then
		set result = preSalary - rs1 - should *  0.3 - 2755;
    elseif should <= 80000 then
		set result = preSalary - rs1 - should *  0.35 - 5505;
    else
		set result = preSalary - rs1 - should *  0.45 - 13505;
    end if;
	return result;
END //


set @rate=(select TaxThreshold  from TaxRate where id = 1);
select 


select CalcNetSalary(8000,3500);


-- 单独计算实发工资
update salary s set NetSalary = (select CalcNetSalary(s.preSalary)) where s.id < 10; 


             













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


-- 税率配置表
INSERT INTO `hrmanagement`.`taxrate` 
	(`TaxThreshold`, `MedicalRateP`, `MedicalRateC`, `EndowmentRateP`, `EndowmentRateC`, `UnemploymentRateP`, `UnemploymentRateC`, `AccidentRateP`, `AccidentRateC`, `MaternityRateP`, `MaternityRateC`, `FundP`, `FundC`) 
VALUES 
	('3500', '0.02', '0.08', '0.08', '0.2', '0.01', '0.02', '0', '0.01', '0', '0.01', '0.035', '0.035');



call `InsertSalaryBatch`(49999,'201509');               











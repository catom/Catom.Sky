

-- ------------------- HrManagement ---------------
-- Date 2015/10/10
-- ---------------------- 建表 -------------
use `hrmanagement`;

-- 薪资表
drop table if exists `salary`;
CREATE TABLE `hrmanagement`.`salary` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `EmployeeId` INT NOT NULL,
  `PreSalary` DECIMAL(6,2) NOT NULL DEFAULT 0,
  `NetSalary` DECIMAL(6,2) NOT NULL DEFAULT 0,
  `Month` VARCHAR(6) NOT NULL,
  `GrantTime` DATETIME NOT NULL,
  PRIMARY KEY (`Id`)
)
COMMENT = '工资表';


-- 税率表
drop table if exists `TaxRate`;
create table `hrmanagement`.`TaxRate`(
    `Id` int not null auto_increment,
    `TaxThreshold` int not null,
    `MedicalRateP` 
    MedicalRateC    医疗保险-公司
    EndowmentRateP    养老保险-个人
    EndowmentRateC    养老保险-公司
    UnemploymentRateP    失业保险-个人
    UnemploymentRateC    失业保险-公司
    AccidentRateP    工伤保险-个人
    AccidentRateC    工伤保险-公司
    MaternityRateP    生育保险-个人
    MaternityRateC    生育保险-公司
    FundP            公积金-个人
    FundC            公积金-公司










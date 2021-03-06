USE master;
GO

CREATE DATABASE tapluyen_db;
GO
USE tapluyen_db;
GO

-- Tao bang: Thong so tap luyen
CREATE TABLE tb_config_practice (
  ConfigID int PRIMARY KEY identity(0,1),
  LiftingPower int default 0,
  [Rate] int default 0,
  RunTime int default 0,
  Note nvarchar(500) default ''
);

-- Tao bang: Benh nhan
CREATE TABLE tb_person (
  ID int identity(1,1),
  PersonID varchar(20) NOT NULL CHECK (PersonID <> N'') PRIMARY KEY,
  NickName nvarchar(50) default '',
  FullName nvarchar(50) default '',
  Birthday datetime default NULL,
  Marital varchar(10) CHECK (Marital IN ('Married', 'Single', 'Other')) default 'Other',
  Gender varchar(6) CHECK (Gender IN ('Male', 'Female', 'Other')) default 'Other',
  ProfessionID int default NULL,
  [Address] nvarchar(250) default '',
  Tel varchar(20) default '',
  MobilePhone varchar(20) default '',
  Email varchar(50) default '',
  Picture image default NULL,
  Note nvarchar(500) default ''
);

-- Tao bang: Bai tap luyen
CREATE TABLE tb_exercise (
  ExerciseID int identity(1,1) PRIMARY KEY,
  Title nvarchar(50) NOT NULL default '',
  [Description] nvarchar(1000) default '',
  Note nvarchar(500) default '',
  ConfigID_Default int default 0,
  CONSTRAINT tb_exercise_practice_fk1 FOREIGN KEY (ConfigID_Default) REFERENCES tb_config_practice (ConfigID)
);

-- Tao bang: Benh nhan tap luyen
CREATE TABLE tb_person_exercise (
	ID int identity(1,1) PRIMARY KEY,
	PersonID varchar(20) NOT NULL UNIQUE,
	ExerciseID int default 0,
	Result nvarchar(100) default '',
	ConfigID int default 0,
	CONSTRAINT tb_person_exercise_fk1 FOREIGN KEY (PersonID) REFERENCES tb_person (PersonID),
	CONSTRAINT tb_person_exercise_fk2 FOREIGN KEY (ExerciseID) REFERENCES tb_exercise (ExerciseID)
);

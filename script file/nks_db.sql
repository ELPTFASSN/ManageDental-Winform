USE master;
GO

CREATE DATABASE nks_db;
GO
USE nks_db;
GO

-- Tao bang: Nghe Nghiep
CREATE TABLE tb_profession (
  ProfessionID int PRIMARY KEY NOT NULL IDENTITY,
  ProfessionName nvarchar(50) NOT NULL default '',
  [Description] nvarchar(500) default NULL
);

-- Tao bang: Benh Nhan
CREATE TABLE tb_patient (
  ID int identity(1,1) PRIMARY KEY,
  PatientID varchar(20) NOT NULL UNIQUE CHECK (PatientID <> N''),
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
  Note nvarchar(500) default '',
  CONSTRAINT tb_patient_professionid_fk FOREIGN KEY (ProfessionID) REFERENCES tb_profession (ProfessionID)
);

-- Tao bang: Tien su benh
CREATE TABLE tb_clinicalrecord (
  ClinicalRecordID int NOT NULL IDENTITY PRIMARY KEY,
  ClinicalRecordName nvarchar(50) NOT NULL default '',
  [Description] nvarchar(500) default ''
);

-- Tao bang quan he: Benh nhan (1-n) Tien su benh
CREATE TABLE tb_patient_clinicalrecord (
  PatientID varchar(20) NOT NULL default '0',
  ClinicalRecordID int NOT NULL default '0',
  Note nvarchar(500) default NULL,
  PRIMARY KEY (PatientID, ClinicalRecordID),
  CONSTRAINT tb_patientclinicalrecord_patientid_fk FOREIGN KEY (PatientID) REFERENCES tb_patient (PatientID),
  CONSTRAINT tb_patientclinicalrecord_clinicalrecordid_fk FOREIGN KEY (ClinicalRecordID) REFERENCES tb_clinicalrecord (ClinicalRecordID)
);

-- Tao bang: Nhan vien
CREATE TABLE tb_employee (
  EmployeeID varchar(20) NOT NULL PRIMARY KEY,
  FirstName nvarchar(50) NOT NULL default '',
  Name nvarchar(50) NOT NULL default '',
  Birthday datetime NOT NULL default '0000-00-00 00:00:00',
  Gender varchar(6) CHECK (Gender IN ('Male', 'Female', 'Other')) default 'Other',
  NativeCountry nvarchar(250) default '',
  [Address] nvarchar(250) default '',
  IdentityCard varchar(20) NOT NULL default '',
  Tel varchar(20) default '',
  MobilePhone varchar(20) default '',
  DateJoin datetime NOT NULL default GETDATE(),
  Email varchar(50) default '',
  Picture image default NULL
);

-- Tao bang: Thuoc
CREATE TABLE tb_medicine (
  MedicineID int NOT NULL IDENTITY PRIMARY KEY,
  MedicineCode varchar(20) UNIQUE NOT NULL default '',
  MedicineName nvarchar(50) NOT NULL default '',
  Country nvarchar(50) default '',
  ServiceLife int default '0',
  UnitLife nvarchar(20) default 'Ngày',
  UsesOfMedicine nvarchar(500) default '',
  UnitType varchar(20) default ''
);

-- Tao bang: Lich hen
CREATE TABLE tb_appointment (
  AppointmentID int NOT NULL IDENTITY PRIMARY KEY,
  DoctorID varchar(20) default '0',
  PatientID varchar(20) default '0',
  StartTime datetime NOT NULL default '0000-00-00 00:00:00',
  EndTime datetime NOT NULL default '0000-00-00 00:00:00',
  Content nvarchar(500) default '',
  [State] varchar(11) CHECK ([State] IN ('HaveDone', 'Unfulfilled', 'Missed')) default 'Unfulfilled',
  CONSTRAINT tb_appointment_employeeid_fk FOREIGN KEY (DoctorID) REFERENCES tb_employee (EmployeeID),
  CONSTRAINT tb_appointment_patientid_fk FOREIGN KEY (PatientID) REFERENCES tb_patient (PatientID)
);

-- Tao bang: Nhom thu thuat
CREATE TABLE tb_relative_paramact (
  relative_paramact_id int NOT NULL IDENTITY PRIMARY KEY,
  relative_paramact_name nvarchar(50) NOT NULL,
  [Description] nvarchar(500) default ''
);

-- Tao bang: Thu thuat
CREATE TABLE tb_paramact (
  ParamActID int IDENTITY NOT NULL PRIMARY KEY,
  ParamActName nvarchar(50) NOT NULL default '',
  TimeOfExecution int NOT NULL default '0',
  [Description] nvarchar(500) default NULL,
  relative_paramact_id int default '0',
  CONSTRAINT tb_paramact_relativeparamactid_fk FOREIGN KEY (relative_paramact_id) REFERENCES tb_relative_paramact (relative_paramact_id)
);

-- Tao bang: Don thuoc mau
CREATE TABLE tb_paramprescription (
  ParamPrescriptionID int IDENTITY NOT NULL PRIMARY KEY,
  ParamPrescriptionName nvarchar(100) NOT NULL default '',
  DoctorID varchar(20) NOT NULL default NULL,
  [Description] nvarchar(500) default NULL,
  CONSTRAINT tb_paramprescription_employeeid_fk FOREIGN KEY (DoctorID) REFERENCES tb_employee (EmployeeID)
);

-- Tao bang quan he: Don thuoc mau (1-n) Thuoc
CREATE TABLE tb_paramprescription_medicine (
  ParamPrescriptionID int NOT NULL default '0',
  MedicineID int NOT NULL default '0',
  Quantity int NOT NULL default '0',
  DirectionsForUse nvarchar(500) NOT NULL default '',
  PRIMARY KEY (MedicineID, ParamPrescriptionID),
  CONSTRAINT tb_paramprescriptionid_medicine_fk FOREIGN KEY (ParamPrescriptionID) REFERENCES tb_paramprescription (ParamPrescriptionID),
  CONSTRAINT tb_paramprescription_medicineid_fk FOREIGN KEY (MedicineID) REFERENCES tb_medicine (MedicineID)
);

-- Tao bang: Mau dot kham
CREATE TABLE tb_examinetype (
  ExamineTypeID int IDENTITY NOT NULL PRIMARY KEY,
  ExamineTypeName nvarchar(50) NOT NULL default '',
  [Description] nvarchar(500) default '',
  ParamPrescriptionID int default NULL,
  CONSTRAINT tb_examinetype_paramprescriptionid_fk FOREIGN KEY (ParamPrescriptionID) REFERENCES tb_paramprescription (ParamPrescriptionID)
);

-- Tao bang quan he: Mau dot kham (1-n) Thu thuat 
CREATE TABLE tb_examinetype_paramact (
  ExamineTypeID int NOT NULL default '0',
  ParamActID int NOT NULL default '0',
  PRIMARY KEY (ExamineTypeID, ParamActID),
  CONSTRAINT tb_examinetypeparamact_examinetypeid_fk FOREIGN KEY (ExamineTypeID) REFERENCES tb_examinetype (ExamineTypeID),
  CONSTRAINT tb_examinetypeparamact_paramactid_fk FOREIGN KEY (ParamActID) REFERENCES tb_paramact (ParamActID)
);

-- Tao bang: Kham benh
CREATE TABLE tb_examination (
  ExaminationID int NOT NULL IDENTITY PRIMARY KEY,
  PatientID varchar(20),
  StartDate datetime default NULL,
  EndDate datetime default NULL,
  ExamineTypeID int default NULL,
  CreateDate datetime NOT NULL default GETDATE(),
  LastEditDate datetime default NULL,
  PersonSettingID varchar(20) NOT NULL default '0',
  IsExamine int NOT NULL default '0',
  CONSTRAINT tb_examination_patientid_fk FOREIGN KEY (PatientID) REFERENCES tb_patient (PatientID),
  CONSTRAINT tb_examination_employeeid_fk FOREIGN KEY (PersonSettingID) REFERENCES tb_employee (EmployeeID),
  CONSTRAINT tb_examination_examinetypeid_fk FOREIGN KEY (ExamineTypeID) REFERENCES tb_examinetype (ExamineTypeID)
);

-- Tao bang: Dieu tri cho dot kham
CREATE TABLE tb_examination_act (
  Examination_ActID int NOT NULL IDENTITY PRIMARY KEY,
  ExaminationID int NOT NULL default '0',
  ParamActID int default NULL,
  StartTime datetime default NULL,
  [Description] nvarchar(500) default NULL,
  [State] varchar(11) CHECK ([State] IN ('HaveDone', 'Unfulfilled', 'Unfinished')) default 'Unfulfilled',
  toothProperty varchar(100) default NULL,
  positionProperty varchar(200) default '""',
  IsCommonAct int default NULL,
  EndTime datetime default NULL,
  DoctorID varchar(20) NOT NULL default '0',
  numberact int default '1',
  CONSTRAINT tb_examinationact_paramactid_fk FOREIGN KEY (ParamActID) REFERENCES tb_paramact (ParamActID),
  CONSTRAINT tb_examinationact_employeeid_fk FOREIGN KEY (DoctorID) REFERENCES tb_employee (EmployeeID),
  CONSTRAINT tb_examinationact_examinationid_fk FOREIGN KEY (ExaminationID) REFERENCES tb_examination (ExaminationID)
);

-- Tao bang: Don thuoc
CREATE TABLE tb_prescription (
  PrescriptionID int NOT NULL IDENTITY PRIMARY KEY,
  ExaminationID int NOT NULL default '0',
  EmployeeID varchar(20) NOT NULL default '0',
  PatientID varchar(20) NOT NULL default '0',
  DateOfIssuee datetime NOT NULL default '0000-00-00 00:00:00',
  [Description] nvarchar(500) default NULL,
  CONSTRAINT tb_prescription_examinationid_fk FOREIGN KEY (ExaminationID) REFERENCES tb_examination (ExaminationID),
  CONSTRAINT tb_prescription_employeeid_fk FOREIGN KEY (EmployeeID) REFERENCES tb_employee (EmployeeID),
  CONSTRAINT tb_prescription_patientid_fk FOREIGN KEY (PatientID) REFERENCES tb_patient (PatientID)
);

-- Tao bang quan he: Don thuoc (1-n) Thuoc
CREATE TABLE tb_prescription_detail (
  MedicineID int NOT NULL default '0',
  PrescriptionID int NOT NULL default '0',
  Quantity int NOT NULL default '0',
  Direction nvarchar(500) default NULL,
  PRIMARY KEY (MedicineID, PrescriptionID),
  CONSTRAINT tb_prescriptiondetail_medicineid_fk FOREIGN KEY (MedicineID) REFERENCES tb_medicine (MedicineID),
  CONSTRAINT tb_prescriptiondetail_prescriptionid_fk FOREIGN KEY (PrescriptionID) REFERENCES tb_prescription (PrescriptionID)
);

-- DANG NHAP QUAN LY TAI KHOAN --


/**
*** INSERT DATA ***
**/
USE nks_db;
GO

INSERT INTO tb_profession (ProfessionName, [Description]) VALUES
(N'Bộ đội', N'Bệnh nhân là người công tác trong quân đội'),
(N'Công an', N'Bệnh nhân là người hoạt động trong ngành công an'),
(N'Cảnh sát giao thông', N'Cảnh sát giao thông'), 
(N'Diễn viên', N'Bệnh nhân là người công tác trong lĩnh vực âm nhạc, nghệ thuật v.v...'),
(N'Giáo viên', N'Bệnh nhân là người hoạt động trong lĩnh vực giảng dạy.'), 
(N'Học sinh - Sinh viên', N'Bệnh nhân đang trong độ tuổi đi học'),
(N'Nghề khác', N'Các nghề khác.'), 
(N'Nội trợ', N'Bệnh nhân là người làm công tác nội trợ'),
(N'Nghề tự do', N'Bệnh nhân là người hoạt động tự do đa ngành nghề'), 
(N'Vận động viên', N'Bệnh nhân là người hoạt động trong lĩnh vực thể dục thể thao.'),
(N'Nghỉ hưu', N'Bệnh nhân đã nghỉ hưu.');
GO

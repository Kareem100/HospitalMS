-- CREATE DATABASE HospitalManagementSystemDatabase;

Drop table CLINIC cascade constraints;
Drop table MEDICAL_STAFF cascade constraints;
Drop table ROOM cascade constraints;
Drop table PATIENT cascade constraints;
Drop table CASE_REPORT cascade constraints;
Drop table CASE_BILL cascade constraints;
Drop table MEDICINE cascade constraints;
Drop table APPOINTMENT cascade constraints;
Drop table STAFF_CONTACTS cascade constraints;
Drop table REPORT_AND_MEDICINE cascade constraints;


Create Table Clinic (
    ClinicName varchar(20) not null primary key,
    FloorNumber int,
    WorkingStartTime varchar(20),
    WorkingEndTime varchar(20)
);


Create Table Room (
    RoomNumber int not null primary key,
    FloorNumber int,
    NumberOfAllBeds int,    
    NumberOfTakenBeds int
);

Create Table Medicine (
    CodeNumber int not null primary key,
    MedicineName varchar(20),
    Price float,
    Quantity int
);

Create Table Medical_Staff (
    NationalID varchar(20) not null primary key,
    FirstName varchar(20),
    LastName varchar(20), 
    Password varchar(20), 
    Gender varchar(20),
    Age int,
    ShiftStart varchar(20),
    ShiftEnd varchar(20),
    Specialization varchar(20),
    YearOfEmployment int,
    ClinicName varchar(20),
    Foreign key (ClinicName) References Clinic(ClinicName) 
);

-- Intermediary table
Create Table Staff_Contacts (
    EmployeeID varchar(20),
    ContactNumber varchar(20),
    Foreign key (EmployeeID) References Medical_Staff(NationalID) 
);

Create Table Patient (
    NationalID varchar(20) not null primary key,
    FirstName varchar(20),
    LastName varchar(20),
    RoomNumber int not null, 
    DoctorID varchar(20),
    Foreign key (RoomNumber) References Room(RoomNumber),
    Foreign key (DoctorID) References Medical_Staff(NationalID)
);


Create Table Appointment (
    AppointmentID int not null primary key, 
    Description varchar(500), 
    PatientID varchar(20), 
    ReceptionistID varchar(20),
    Foreign key (PatientID) References Patient(NationalID),
    Foreign key (ReceptionistID) References Medical_Staff(NationalID) 
); 

Create Table Case_Report (
    ReportID int not null primary key,
    DateIn date,
    DateOut date,
    ConditionalIllness varchar(50),
    PatientID varchar(20), 
    DoctorID varchar(20),
    Foreign key (PatientID) References Patient(NationalID),
    Foreign key (DoctorID) References Medical_Staff(NationalID) 
);


-- Intermediary table
Create Table Report_And_Medicine (
    ReportID int,
    MedicineCode int,
    MedicQuantityTaken int,
    Primary key(ReportID, MedicineCode),
    Foreign key(MedicineCode) References Medicine(CodeNumber),
    Foreign key(ReportID) References Case_Report(ReportID)  
);

Create Table Case_Bill ( 
    BillNumber int not null primary key,
    ReportID int unique,
    MedicsTotalPrice float,
    TotalBillAmount float,
    Foreign key (ReportID) References Case_Report(ReportID)
);


-- Inserting static data into Clinic table.
Insert into Clinic values('Mental Health', 1, '10:05', '18:00');
Insert into Clinic values('Dentistry', 2, '10:00', '15:00');
Insert into Clinic values('Nutrition', 3, '08:00', '12:00');
Insert into Clinic values('Dermatology', 4, '08:05', '10:00');
Insert into Clinic values('Oncology', 5, '21:05', '23:00');

-- Inserting static data into Room table.
Insert into Room values(201, 2, 3, 2);
Insert into Room values(205, 2, 3, 1);
Insert into Room values(210, 3, 4, 2);
Insert into Room values(218, 4, 2, 2);
Insert into Room values(223, 3, 1, 0);

-- Inserting static data into Medicine table.
Insert into Medicine values(78019, 'Xanax', 30.5, 3);
Insert into Medicine values(78054, 'Amoxicillin', 100, 5);
Insert into Medicine values(78065, 'Penicillin', 200.80, 1);
Insert into Medicine values(78074, 'Methotrexate', 154.60, 3);
Insert into Medicine values(78089, 'Doxil', 130.5, 4);

-- Inserting static data into Medical_Staff table.
Insert into medical_staff values ('29891011407730', 'Sameh', 'Hussein', '1234', 'Male', 48, '12:08 PM', '06:10 PM', 'Doctor', 1999, 'Dentistry');
Insert into medical_staff values ('29831011407729', 'Adel', 'Emam', '1234', 'Male', 56, '02:00 PM', '10:00 PM', 'Doctor', 1993, 'Nutrition');
Insert into medical_staff values ('29991011407725', 'Sabry', 'Hamam', '1234', 'Male', 30, '08:00 AM', '06:00 PM', 'Receptionist', 2005, null);

-- Inserting static data into Staff_Contacts table.
Insert into staff_contacts values ('29891011407730', '01034512875');
Insert into staff_contacts values ('29891011407730', '01230512870');
Insert into staff_contacts values ('29831011407729', '01144785954');
Insert into staff_contacts values ('29991011407725', '01531215648');

-- Inserting static data into Patient table.
Insert into patient values('30001011407738', 'Ahmed', 'Shaker', 201, '29891011407730');
Insert into patient values('30001011407727', 'Bahaa', 'Aly', 205, '29891011407730');
Insert into patient values('30101011407750', 'Salma', 'Nasser', 210, '29831011407729');

-- Inserting static data into Appointment table.
Insert into appointment values (10, 'Symptoms of teeth grinding during the night. When waking up, feeling pain in the jaw.', '30001011407738', '29991011407725');
Insert into appointment values (11, 'Harmfull tooth causing a painful headach.', '30001011407727', '29991011407725');
Insert into appointment values (12, 'Harmfull tooth causing a painful headach.', '30101011407750', '29991011407725');

-- Inserting static data into Case_Report table.
Insert into case_report values (1, '01-May-21', '06-May-21', 'Sharp pain on touching his tooth or bite down.', '30001011407738', '29891011407730');
Insert into case_report values (2, '02-Apr-21', '20-Apr-21', 'Being overweight and obese.', '30101011407750', '29831011407729');

-- Inserting static data into Report_And_Medicine table.
Insert into report_and_medicine values (2, 78089, 5);
Insert into report_and_medicine values (2, 78019, 3);
Insert into report_and_medicine values (1, 78074, 2);

-- Inserting static data into Case_Bill table.
Insert into case_bill values (113, 2, 744, 2544);
Insert into case_bill values (114, 1, 309.2, 809.2);


-- Commit Changes Made
commit;

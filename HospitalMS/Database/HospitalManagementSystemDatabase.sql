-- CREATE DATABASE HospitalManagementSystemDatabase;

Drop Table if exists Clinic;
Drop Table if exists Room;
Drop Table if exists Medicine;
Drop Table if exists Stuff_Contacts;
Drop Table if exists Report_And_Medicine;


Create Table Clinic (
    ClinicID int not null primary key,
    ClinicName varchar(100),
    FloorNumber int,
    WorkingStartTime float,
    WorkingEndTime float 
);

Create Table Medical_Stuff (
    NationalID int not null primary key,
    FirstName varchar(100),
    LastName varchar(100), 
    Password varchar(100), 
    Gender varchar(100),
    Age float,
    ShiftStart float,
    ShiftEnd float,
    Specialization varchar(100),
    YearOfEmployment int,
    ClinicName varchar(100)
);

Create Table Patient (
    NationalID int not null primary key,
    FirstName varchar(50),
    LastName varchar(50),
    RoomNumber int, 
    DoctorID int
);

Create Table Room (
    RoomNumber int not null primary key,
    FloorNumber int,
    NumberOfAllBeds int,    
    NumberOfTakenBeds int
);

Create Table CaseReport (
    ReportID int not null primary key,
    DurationStart date,
    DurationEnd date, 
    ConditionalIllness varchar(100),
    PatientID int, 
    DoctorID int
);

Create Table Bill ( 
    BillNumber int not null primary key, 
    InDate date, 
    OutDate date, 
    TotalAmount float,
    ReportID int
);

Create Table Medicine (
    CodeNumber int not null primary key,
    MedicineName varchar (100),
    Price float,
    Quantity int
);

Create Table Appointment (
    AppointmentID int not null primary key, 
    Description varchar(500), 
    PatientID int, 
    ReceptionistID int
); 

-- Intermediary table
Create Table Stuff_Contacts (
    ContactNumber int,
    EmployeeID int,
    primary key(ContactNumber, EmployeeID)
);

-- Intermediary table
Create Table Report_And_Medicine (
    ReportID int, 
    MedicineCode int,
    primary key(ReportID, MedicineCode)
);


-- Put static data into Clinic table.
Insert into Clinic values(8801, 'Mental Health', 1, '10:05', '18:00');
Insert into Clinic values(8802, 'Dentistry', 2, '10:00', '15:00');
Insert into Clinic values(8803, 'Nutrition', 3, '08:00', '12:00');
Insert into Clinic values(8804, 'Dermatology', 4, '08:05', '10:00');
Insert into Clinic values(8805, 'Oncology', 5, '21:05', '23:00');

-- Put static data into Room table.
Insert into Room values(201, 2, 3, 2);
Insert into Room values(205, 2, 3, 1);
Insert into Room values(210, 3, 4, 2);
Insert into Room values(218, 4, 2, 2);
Insert into Room values(223, 3, 1, 0);

-- Put static data into Medicine table.
Insert into Medicine values(78019, 'Xanax', 30.5, 3);
Insert into Medicine values(78054, 'Amoxicillin', 100, 5);
Insert into Medicine values(78065, 'Penicillin', 200.80, 1);
Insert into Medicine values(78074, 'Methotrexate', 154.60, 3);
Insert into Medicine values(78089, 'Doxil', 130.5, 4);
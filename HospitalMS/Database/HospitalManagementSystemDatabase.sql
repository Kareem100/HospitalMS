-- CREATE DATABASE HospitalManagementSystemDatabase;

Drop Table if exists Clinic;
Drop Table if exists Room;
Drop Table if exists Medicine;
Drop Table if exists Stuff_Contacts;
Drop Table if exists Report_And_Medicine;


Create Table Clinic (
    ClinicName varchar(20) not null primary key,
    FloorNumber int,
    WorkingStartTime varchar(20),
    WorkingEndTime varchar(20)
);

Create Table Medical_Stuff (
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
    ClinicName varchar(20)
);

Create Table Patient (
    NationalID varchar(20) not null primary key,
    FirstName varchar(20),
    LastName varchar(20),
    RoomNumber int, 
    DoctorID varchar(20)
);

Create Table Room (
    RoomNumber int not null primary key,
    FloorNumber int,
    NumberOfAllBeds int,    
    NumberOfTakenBeds int
);

Create Table Case_Report (
    ReportID int not null primary key,
    DurationStart date,
    DurationEnd date, 
    ConditionalIllness varchar(20),
    PatientID varchar(20), 
    DoctorID varchar(20) 
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
    MedicineName varchar(20),
    Price float,
    Quantity int
);

Create Table Appointment (
    AppointmentID int not null primary key, 
    Description varchar(500), 
    PatientID varchar(20), 
    ReceptionistID varchar(20)
); 

-- Intermediary table
Create Table Stuff_Contacts (
    ContactNumber varchar(20),
    EmployeeID varchar(20),
    primary key(ContactNumber, EmployeeID)
);

-- Intermediary table
Create Table Report_And_Medicine (
    ReportID int, 
    MedicineCode int,
    primary key(ReportID, MedicineCode)
);


-- Put static data into Clinic table.
Insert into Clinic values('Mental Health', 1, '10:05', '18:00');
Insert into Clinic values('Dentistry', 2, '10:00', '15:00');
Insert into Clinic values('Nutrition', 3, '08:00', '12:00');
Insert into Clinic values('Dermatology', 4, '08:05', '10:00');
Insert into Clinic values('Oncology', 5, '21:05', '23:00');

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
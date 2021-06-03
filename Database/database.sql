CREATE DATABASE HospitalManagementSystemDatabase;

Create Table Clinic (
    ClinicName varchar(100) primary key,
    FloorNumber int,
    WorkingHoursStart float,
    WorkingHoursEnd float 
);

Create Table Doctor (
    NationalID int unique not null primary key,
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
    NationalID int unique not null primary key,
    FirstName varchar(50),
    LastName varchar(50),
    RoomNumber int, 
    DoctorID int
);

Create Table Room (
    RoomNumber int unique not null primary key,
    FloorNumber int,
    NumberOfAllBeds int,    
    NumberOfTakenBeds int
);

Create Table Report (
    ReportID int unique not null primary key,
    DurationStart date,
    DurationEnd date, 
    ConditionalIllness varchar(100),
    PatientID int, 
    DoctorID int
);

Create Table Bill ( 
    BillNumber int unique not null primary key, 
    InDate date, 
    OutDate date, 
    TotalAmount float,
    ReportID int
);

Create Table Medicine (
    CodeNumber int unique not null primary key,
    MedicineName varchar (100),
    Price float,
    Quantity int
);

Create Table Appointment (
    AppointmentID int unique not null primary key, 
    Description varchar(500), 
    PatientID int, 
    ReceptionistID int
); 
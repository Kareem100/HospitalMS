CREATE DATABASE HospitalManagementSystemDatabase;

Create Table Clinic (
    ClinicID int unique not null primary key,
    ClinicName varchar(100),
    FloorNumber int,
    WorkingStartTime float,
    WorkingEndTime float 
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


-- Put static data into Clinic table.
insert into Clinic values(8801, 'Mental Health', 1, '10:05', '18:00');
insert into Clinic values(8802, 'Dentistry', 2, '10:00', '15:00');
insert into Clinic values(8803, 'Nutrition', 3, '08:00', '12:00');
insert into Clinic values(8804, 'Dermatology', 4, '08:05', '10:00');
insert into Clinic values(8805, 'Oncology', 5, '21:05', '23:00');

-- Put static data into Room table.
insert into Room values(201, 2, 3, 2);
insert into Room values(205, 2, 3, 1);
insert into Room values(210, 3, 4, 2);
insert into Room values(218, 4, 2, 2);
insert into Room values(223, 3, 1, 0);

-- Put static data into Medicine table.
insert into Medicine values(78019, 'Xanax', 30.5, 3);
insert into Medicine values(78054, 'Amoxicillin', 100, 5);
insert into Medicine values(78065, 'Penicillin', 200.80, 1);
insert into Medicine values(78074, 'Methotrexate', 154.60, 3);
insert into Medicine values(78089, 'Doxil', 130.5, 4);
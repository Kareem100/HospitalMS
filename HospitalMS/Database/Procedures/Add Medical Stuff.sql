create or replace PROCEDURE addMedicalStuff
(NID IN VARCHAR2,
FirstName IN VARCHAR2,
LastName IN VARCHAR2,
uPassword IN VARCHAR2,
Gender IN VARCHAR2,
Age IN NUMBER,
Specialization IN VARCHAR2,
YearOfEmployment IN NUMBER,
ClinicName IN VARCHAR2,
Phone IN VARCHAR2)
IS
BEGIN
  INSERT INTO medical_stuff VALUES (NID, FirstName, LastName, uPassword, 
                                    Gender, Age, 'Not Stated', 'Not Stated', 
                                    Specialization, YearOfEmployment, ClinicName);
  INSERT INTO stuff_contacts VALUES (NID, Phone);
END addMedicalStuff;
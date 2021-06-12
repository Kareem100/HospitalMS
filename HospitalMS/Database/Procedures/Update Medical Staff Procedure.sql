create or replace PROCEDURE updateMedicalStaff
(NID IN VARCHAR2,
mFirstName IN VARCHAR2,
mLastName IN VARCHAR2,
mGender IN VARCHAR2,
mAge IN NUMBER,
mShiftStart IN VARCHAR2,
mShiftEnd IN VARCHAR2,
mSpecialization IN VARCHAR2,
mYearOfEmployment IN NUMBER,
mClinicName IN VARCHAR2)
IS
BEGIN
update medical_staff 
set firstname = mFirstName, lastname = mLastName, gender = mGender, age = mAge,
shiftstart = mShiftStart, shiftend = mShiftEnd, specialization = mSpecialization,
yearofemployment = mYearOfEmployment, clinicname = mClinicname
where nationalid = NID;
END updateMedicalStaff;

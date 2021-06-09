create or replace PROCEDURE INSERTPATIENT
( NID IN VARCHAR2
, FirstName IN VARCHAR2
, LastName IN VARCHAR2
, RoomNum IN NUMBER
, DoctorID IN VARCHAR2
) AS
BEGIN
  insert into patient (nationalid , firstname , lastname , roomnumber, doctorid)
  values (nid , firstname, lastname, roomnum, doctorid);
  
END INSERTPATIENT;
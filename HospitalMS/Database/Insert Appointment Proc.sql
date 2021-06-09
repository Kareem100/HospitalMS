create or replace PROCEDURE INSERTAPPOINTMENT
( 
AppointmentId IN NUMBER
, Description IN VARCHAR2
, PatientID IN VARCHAR2
, ReceptionistID IN VARCHAR2
) AS
BEGIN
  
  INSERT into appointment (appointmentid , description, patientid, receptionistid)
  values (appointmentid , description , patientid , receptionistid);
END INSERTAPPOINTMENT;
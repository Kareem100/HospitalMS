create or replace PROCEDURE UPDATEPASSWORD
( NID IN VARCHAR2 
, NewPassword IN VARCHAR2
) AS
BEGIN
 update medical_staff 
 set password = newpassword
 where nationalid = nid ;
 
END UPDATEPASSWORD;

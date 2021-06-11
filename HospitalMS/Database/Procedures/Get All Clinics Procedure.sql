create or replace
PROCEDURE getClinics
(clinics OUT SYS_REFCURSOR)
AS
BEGIN
OPEN clinics FOR
SELECT * FROM clinic;
END getClinics;

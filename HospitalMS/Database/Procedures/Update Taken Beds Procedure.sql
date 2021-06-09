create or replace PROCEDURE UPDATETAKENBEDS
( RoomNum IN NUMBER
) AS
BEGIN
update ROOM 
set numberoftakenbeds = numberoftakenbeds + 1
where roomnumber = RoomNum ;
END UPDATETAKENBEDS;
 CREATE OR REPLACE PROCEDURE RETRIEVEROOM
 (RoomID IN INTEGER, RoomNumber_Out OUT INTEGER, FloorNumber_Out OUT INTEGER, NumberOfAllBeds_Out OUT INTEGER, NumberOfTakenBeds_Out OUT INTEGER) 
 AS
 BEGIN
  Select
    	Room.RoomNumber, Room.FloorNumber, Room.NumberOfAllBeds, Room.NumberOfTakenBeds
  INTO
    	RoomNumber_Out, FloorNumber_Out, NumberOfAllBeds_Out, NumberOfTakenBeds_Out
  From Room 
  Where Room.RoomNumber = RoomID;
 END;



Create Table CabinTable
(
CabinId int identity(1,1) primary key,
CabinNo numeric(15),
RoomNo numeric(15),
CabinType varchar(50),
Doctor varchar(50),
Staff varchar(50)
)

Create Procedure SP_ManageCabins
(
@CabinId int,
@CabinNo numeric(15),
@RoomNo numeric(15),
@CabinType varchar(50),
@Doctor varchar(50),
@Staff varchar(50),
@Mode int
)
as
begin
if(@Mode=1)
insert into CabinTable(CabinNo,RoomNo,CabinType,Doctor,Staff) values
(@CabinNo,@RoomNo,@CabinType,@Doctor,@Staff)
if (@Mode=2)
Update CabinTable set CabinNo=@CabinNo,RoomNo=@RoomNo,CabinType=@CabinType,Doctor=@Doctor,Staff=@Staff
where CabinId=@CabinId
if(@Mode=3)
Delete from CabinTable where CabinId=@CabinId
end
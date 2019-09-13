Create Table StaffTable
(
StaffId int identity(1,1) primary key,
StaffNo numeric(15), StaffName varchar(50), Category varchar(50), WardNo numeric(15),
Qualification varchar(100), DOB date, Gender varchar(50), MaritalStatus varchar(50),
BloodGroup varchar(3), DutyTime time, EndTime time, Image image
)

Create Procedure SP_ManageStaffs
(
@StaffId int, @StaffNo numeric(15), @StaffName varchar(50),
@Category varchar(50), @WardNo numeric(15), @Qualification varchar(100),
@DOB date, @Gender varchar(50), @MaritalStatus varchar(50), @BloodGroup varchar(3),
@DutyTime time, @EndTime time, @Image image, @Mode int
)
as
begin
if(@Mode=1)
insert into StaffTable(StaffNo,StaffName,Category,WardNo,Qualification,DOB,Gender,MaritalStatus,BloodGroup,DutyTime,EndTime,Image) values 
(@StaffNo,@StaffName,@Category,@WardNo,@Qualification,@DOB,@Gender,@MaritalStatus,@BloodGroup,@DutyTime,@EndTime,@Image)
if (@Mode=2)
Update StaffTable set StaffNo=@StaffNo,StaffName=@StaffName,Category=@Category,WardNo=@WardNo,Qualification=@Qualification,
DOB=@DOB,Gender=@Gender,MaritalStatus=@MaritalStatus,BloodGroup=@BloodGroup,DutyTime=@DutyTime,EndTime=@EndTime,Image=@Image
where StaffId=@StaffId
if(@Mode=3)
Delete from StaffTable where StaffId=@StaffId
end
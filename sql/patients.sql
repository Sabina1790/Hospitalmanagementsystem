Create Table PatientTable
(
PatientId int identity(1,1) primary key,
VisitorNo numeric(15),
Title varchar(50),
PatientName varchar(50),
Address varchar(50),
ContactNo numeric(10),
DOB date,
Gender varchar(50),
PatientType varchar(50),
MaritialStatus varchar(50),
BloodGroup varchar(3),
Image image
)

Create Procedure SP_ManagePatients
(
@PatientId int,
@VisitorNo numeric(15),
@Title varchar(50),
@PatientName varchar(50),
@Address varchar(50),
@ContactNo numeric(10),
@DOB date,
@Gender varchar(50),
@PatientType varchar(50),
@MaritialStatus varchar(50),
@BloodGroup varchar(3),
@Image image,
@Mode int
)
as
begin
if(@Mode=1)
insert into PatientTable(VisitorNo,Title,PatientName,Address,ContactNo,DOB,Gender,PatientType,MaritialStatus,BloodGroup,Image) values 
(@VisitorNo,@Title,@PatientName,@Address,@ContactNo,@DOB,@Gender,@PatientType,@MaritialStatus,@BloodGroup,@Image)
if (@Mode=2)
Update PatientTable set VisitorNo=@VisitorNo,Title=@Title,PatientName=@PatientName,Address=@Address,ContactNo=@ContactNo,
DOB=@DOB,Gender=@Gender,PatientType=@PatientType,MaritialStatus=@MaritialStatus,BloodGroup=@BloodGroup,Image=@Image
where PatientId=@PatientId
if(@Mode=3)
Delete from PatientTable where PatientId=@PatientId
end
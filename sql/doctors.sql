Create Table DoctorTable
(
DoctorId int identity(1,1) primary key,
ReferringNo numeric(15),
FirstName varchar(50),
LastName varchar(50),
Speciality varchar(100),
ContactNo numeric(10),
DOB date,
Gender varchar(50),
Address varchar(50),
ReferringRate varchar(50),
BloodGroup varchar(3),
Image image
)

Create Procedure SP_ManageDoctor
(
@DoctorId int,
@ReferringNo numeric(15),
@FirstName varchar(50),
@LastName varchar(50),
@Speciality varchar(100),
@ContactNo numeric(10),
@DOB date,
@Gender varchar(50),
@Address varchar(50),
@ReferringRate varchar(50),
@BloodGroup varchar(3),
@Image image,
@Mode int
)
as
begin
if(@Mode=1)
insert into DoctorTable(ReferringNo,FirstName,LastName,Speciality,ContactNo,DOB,Gender,Address,ReferringRate,BloodGroup,Image) values 
(@ReferringNo,@FirstName,@LastName,@Speciality,@ContactNo,@DOB,@Gender,@Address,@ReferringRate,@BloodGroup,@Image)
if (@Mode=2)
Update DoctorTable set ReferringNo=@ReferringNo,FirstName=@FirstName,LastName=@LastName,Speciality=@Speciality,ContactNo=@ContactNo,
DOB=@DOB,Gender=@Gender,Address=@Address,ReferringRate=@ReferringRate,BloodGroup=@BloodGroup,Image=@Image
where DoctorId=@DoctorId
if(@Mode=3)
Delete from DoctorTable where DoctorId=@DoctorId
end
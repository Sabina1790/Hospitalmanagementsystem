Create Table MedicineTable
(
MedicineId int identity(1,1) primary key,
VisitorNo numeric(15),
PatientName varchar(50),
ReferringNo numeric(15),
DoctorName varchar(50),
ReferredMedicines varchar(100),
MfgDate date,
ExpiredDate date,
SupplierName varchar(50),
CompanyName varchar(50),
Image1 image,
Image2 image
)

Create Procedure SP_ManageMedicines
(
@MedicineId int,
@VisitorNo numeric(15),
@PatientName varchar(50),
@ReferringNo numeric(15),
@DoctorName varchar(50),
@ReferredMedicines varchar(100),
@MfgDate date,
@ExpiredDate date,
@SupplierName varchar(50),
@CompanyName varchar(50),
@Image1 image,
@Image2 image,
@Mode int
)
as
begin
if(@Mode=1)
insert into MedicineTable(VisitorNo,PatientName,ReferringNo,DoctorName,ReferredMedicines,MfgDate,
ExpiredDate,SupplierName,CompanyName,Image1,Image2) values
(@VisitorNo,@PatientName,@ReferringNo,@DoctorName,@ReferredMedicines,@MfgDate,@ExpiredDate,@SupplierName,
@CompanyName,@Image1,@Image2)
if (@Mode=2)
Update MedicineTable set VisitorNo=@VisitorNo,PatientName=@PatientName,ReferringNo=@ReferringNo,DoctorName=@DoctorName,
ReferredMedicines=@ReferredMedicines,MfgDate=@MfgDate,ExpiredDate=@ExpiredDate,SupplierName=@SupplierName,
CompanyName=@CompanyName,Image1=@Image1,Image2=@Image2
where MedicineId=@MedicineId
if(@Mode=3)
Delete from MedicineTable where MedicineId=@MedicineId
end
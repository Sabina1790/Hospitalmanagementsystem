Create Table SaleTable
(
SaleId int identity(1,1) primary key,
VisitorNo numeric(15),
PatientName varchar(50),
ReferringNo numeric(15),
DoctorName varchar(50),
ReferredMedicines varchar(100),
SalesPrice numeric(20),
Quantity numeric(20),
TotalPrice numeric(20),
Image1 image,
Image2 image
)

Create Procedure SP_ManageSales
(
@SaleId int,
@VisitorNo numeric(15),
@PatientName varchar(50),
@ReferringNo numeric(15),
@DoctorName varchar(50),
@ReferredMedicines varchar(100),
@SalesPrice numeric(20),
@Quantity numeric(20),
@TotalPrice numeric(20),
@Image1 image,
@Image2 image,
@Mode int
)
as
begin
if(@Mode=1)
insert into SaleTable(VisitorNo,PatientName,ReferringNo,DoctorName,ReferredMedicines,SalesPrice,Quantity,TotalPrice,Image1,Image2) values
(@VisitorNo,@PatientName,@ReferringNo,@DoctorName,@ReferredMedicines,@SalesPrice,@Quantity,@TotalPrice,@Image1,@Image2)
if (@Mode=2)
Update SaleTable set VisitorNo=@VisitorNo,PatientName=@PatientName,ReferringNo=@ReferringNo,DoctorName=@DoctorName,
ReferredMedicines=@ReferredMedicines,SalesPrice=@SalesPrice,Quantity=@Quantity,TotalPrice=@TotalPrice,Image1=@Image1,Image2=@Image2
where SaleId=@SaleId
if(@Mode=3)
Delete from SaleTable where SaleId=@SaleId
end
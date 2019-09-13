Create Table UserTable
(
UserId int identity(1,1) primary key,
UserName varchar(50),
Password varchar(50),
Role varchar(50)
)

Create Procedure SP_ManageUsers
(
@UserId int, @UserName varchar(50), @Password varchar(50), @Role varchar(50),@Mode int
)
as
begin
if(@Mode=1)
insert into UserTable(UserName,Password,Role) values 
(@UserName,@Password,@Role)
if (@Mode=2)
Update UserTable set UserName=@UserName,Password=@Password,Role=@Role
where UserId=@UserId
if(@Mode=3)
Delete from UserTable where UserId=@UserId
end
create database ProjectQLKTPDB
go

use ProjectQLKTPDB
go
drop database ProjectQLKTPDB


--Nhà cung cấp
create table Suplier
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max),
	Address nvarchar(max),
	Phone nvarchar(20),
	Email nvarchar(200),
	MoreInfo nvarchar(max),
	ContractDate Datetime
)
go

--Khách hàng
create table Customer
(
	CustomerId int identity(1,1) primary key,
	DisplayNameCustomer nvarchar(max),
	Address nvarchar(max),
	Phone nvarchar(20),
	Email nvarchar(200),
	MoreInfo nvarchar(max),
	ContractDate Datetime
)
go

--Đối tượng
create table Food
(
	FoodId int identity(1,1) primary key,
	DisplayNameFood nvarchar(max),
	Quantity int ,
	Image varchar(max),
	IdSuplier int not null,
	DateOfManufacture Datetime,
	ExpirationDate Datetime

	foreign key(IdSuplier) references Suplier(Id)
)
go

--Vai trò user
create table UserRole
(
	RoleId int identity(1,1) primary key,
	DisplayNameRole nvarchar(max),
)
go

insert into UserRole(DisplayNameRole) values(N'Admin')
go
insert into UserRole(DisplayNameRole) values(N'Staff')
go

create table Users
(
	Id int identity(1,1) primary key,
	DisplayNameUser nvarchar(max),
	UserName nvarchar(100),
	PassWord nvarchar(max),
	IdRole int not null

	foreign key(IdRole) references UserRole(RoleId)
)
go

insert into Users(DisplayNameUser, UserName, PassWord, IdRole) values(N'PhongPhu', N'admin', N'123456',1)
go

insert into Users(DisplayNameUser, UserName, PassWord, IdRole) values(N'KhuongDuy', N'Staff', N'123456',2)
go

--Phiếu nhập
create table Input
(
	InputId int identity(1,1) primary key,
	DateInput Datetime,
	TotalPrice int,
	IdSuplier int not null
	foreign key(IdSuplier) references Suplier(Id)
)
go

--Thông tin phiếu nhập
create table InputInfo
(
	Id int identity(1,1) primary key,
	IdFood int not null,
	IdInput int not null,
	CountInput int,
	InputPrice float default 0,
	StatusInput nvarchar(max)

	foreign key(IdFood) references Food(FoodId) ON DELETE CASCADE,
	foreign key(IdInput) references Input(InputId) ON DELETE CASCADE
)
go

--Phiếu xuất
create table Output
(
	OutputId int identity(1,1) primary key,
	DateOutput Datetime,
	TotalPrice int
)
go

--Thông tin phiếu xuất
create table OutputInfo
(
	Id int identity(1,1) primary key,
	IdFood int not null,
	IdOutput int not null,
	IdInputInfo int not null,
	IdCustomer int not null,
	CountOutput int,
	OutputPrice float default 0,
	StatusOutput nvarchar(max)

	foreign key(IdFood) references Food(FoodId),
	foreign key(IdOutput) references Output(OutputId) ON DELETE CASCADE,
	foreign key(IdInputInfo) references InputInfo(Id) ON DELETE CASCADE,
	foreign key(IdCustomer) references Customer(CustomerId) ON DELETE CASCADE
)
go
drop table InputInfo

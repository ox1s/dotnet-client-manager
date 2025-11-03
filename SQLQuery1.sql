create database ClientsDB;
use ClientsDB;
create table Clients (
	Id int primary key identity,
	FullName nvarchar(25),
	Email nvarchar(15),
	IsActive bit,
	CreatedAt datetime
	);
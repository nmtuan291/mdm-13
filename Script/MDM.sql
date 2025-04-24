create database MDM
go

use MDM
go

create table Accounts (
	userId varchar(255) primary key,
	userName varchar(255) unique,
	email varchar(100) unique,
	phoneNumber varchar(15) unique,
	passwordHash varchar(50),
	accountStatus varchar(20)
)
go

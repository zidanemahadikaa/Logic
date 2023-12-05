CREATE DATABASE XPOS329

USE XPOS329
/*DDL
--//CREATE
CREATE <OBJECT_TYPE> <NAMA_OBJECT>(
)

e.g:
CREATE DATABASE TEST_DB  // Membuat database baru dengan nama TEST_DB

CREATE TABLE COBA (
	ID INT PRIMARY KEY,
	NAMA VARCHAR(128) NOT NULL
	ALAMAT VARCHAR(500)
)						//--> Membuat table baru dengan 3 column (ID, NAMA, ALAMAT) 

CREATE VIEW VW_SEMUA_PERSON // --> Membuat sebuah object view untuk menampilkan seluruh isi table persons
AS
	SELESAI * FROM PERSONS

CREATE LOGIN penjual			//--> Membuat Login baru u/ SQL server dengan nama penjual
	WITH PASSWORD='penjual',    //--> dan password penjual
	DEFAULT_DATABASE=XPOS329,   //    untuk DATABASE XPOS329
	CHECK_EXPIRATION=OFF,		//--> tanpa syarat kadaluarsa
	CHECK_POLICY=OFF			//--> tanpa syarat strong password
go

CREATE USER [penjual] FOR LOGIN [penjual]
GO
--//ALTER
ALTER <OBJECT_TYPE>
	<STATEMENT_ALTER>:
		- ADD   : Menambahkan bagian baru (COLUMN/CONSTRAINT) ke suatu OBJECT database
		- DROP  : Membuang suatu bagian dari object database
		- ALTER : Merubah suatu bagian dari object database

e.g:
ALTER TABLE COBA			//--> Menambah column ID sebagai primary key pada table COBA
	ADD  CONSTRAINT PK_COBA PRIMARY KEY(ID)

ALTER TABLE COBA			//--> Membuang suatu constraint dari table COBA berdasarkan			
	DROP CONSTRAINT PK_COBA // nama constraintnya (PK_COBA)]

ALTER TABLE COBA			//--> Merubah ukuran Column NAMA dari table COBA menjadi 100 character
	ALTER COLUMN NAMA VARCHAR(100)

--DROP
DROP <OBJECT_TYPE> <NAMA_OBJECT>

e.g:
DROP DATABASE XPOS329		//--> Menghapus object DATABASE COBA berikut isinya

DROP TABLE COBA				//--> Menghapus Object TABLE COBA dari database

*/
/* Index Table
	- CREATE INDEX <nama_index> ON <table_name> (<column_name>)
	- CREATE UNIQUE INDEX <nama_index> ON <table_name> (<column_name>)
	- CREATE CLUSTERED INDEX <nama_index> ON <table_name>(<column_name>)

*/

/* DCL
GRANT <QUERY_TYPE> [SELECT, INSERT, DELETE, UPDATE/ALL]
ON <ONJECT_NAME>
TO <USER_NAME>

e.g.:
GRANT SEL
	ECT ON [XPOS329.DBO.ORFERS]
	TO [PENJUAL]

*/
CREATE TABLE Tbl_M_Categories(
	id int identity(1,1),
	category_name varchar(100) not null,
	description varchar(MAX),
	is_deleted bit default(0),

	create_by int,
	create_date datetime default(getdate()),
	update_by int,
	update_date datetime,
	constraint pk_Tbl_M_Categories primary key (id)
)
CREATE TABLE persons(
	ID int NOT NULL,
	LastName varchar(255) NOT NULL,
	FirstName varchar(255),
	Age int,
	City varchar(255),
	constraint PK_persons PRIMARY KEY (ID)
);
CREATE TABLE Orders(
	OrderID int NOT NULL PRIMARY KEY,
	OrderNumber int NOT NULL,
	OrderDate date DEFAULT GETDATE(),
	PersonID int
		FOREIGN KEY
		REFERENCES persons(ID)
);

INSERT INTO Persons
VALUES (1,'Indri''yani', 'Raya', 21, 'Jakarta')

INSERT INTO Persons (id, FirstName, LastName, City, Age)
VALUES (2,'Katniss', 'Everdeen', 'New York', 20)

INSERT INTO Persons (id, FirstName, LastName, Age)
VALUES (3,'Robert', 'Downey Jr.', 20)

-- akan error karena LstName tidak ada
INSERT INTO Persons (id, FirstName, Age)
VALUES (4,'Merlin', 20)

--akan error karena ID sudah ada sebelumnya
INSERT INTO Persons (id, LastName, Age)
VALUES (3,'Merlin', 20)

--menampilkan semua data table persons
select * from persons

INSERT INTO Persons (id, LastName, Age)
VALUES (4,'Merlin', 20)

INSERT INTO Persons (id, FirstName, LastName, Age)
VALUES (5,'Artur', 'NULL', 20)

INSERT INTO Persons (id, FirstName, LastName, Age)
VALUES (6, NULL, 'Arthur', 20)

--akan error karena Lastname tidak ada
INSERT INTO Persons (id, FirstName, LastName, Age)
VALUES (7,'Cecep', NULL, 20)

INSERT INTO persons
(ID, LastName, Age)
VALUES
(7, 'cecep', 20),
(8, 'Agus', 20),
(9, 'rama', 20)

insert into persons (ID, FirstName, LastName, Age, City)
	SELECT ID, FirstName, LastName, Age, City from persons_old

--DLL Menghapus data
DELETE FROM persons
WHERE ID=1

/*create table coba(
	id int identity(1,1) primary key,
	Nama varchar(100) not null,
	alamat varchar(255)
)

INSERT INTO coba
values(1,'coba', 'dimana-mana')*/

insert into Orders
values(1,1, '2023-09-01 9:50:00', 1)

insert into Orders
values(2,2, GETDATE(), 2)

delete from Orders
where OrderID=1

--Menyalin selurh isi tabel ke table baru
select * 
into persons_old
from persons

--DML Ubah data
update persons
	set FirstName= 'The wizard'
where
	id=4
where City = 'sandnes'



update
persons
	set 
	LastName ='Pendgragon',
	FirstName = 'Arthur'
where 
	id=5

update 
persons
	set age = 17

-- DDL untuk merubah struktur tabel
sp_rename 
GO

sp_help orders
GO

sp_help persons

alter table orders
	drop constraint FK__Orders__PersonID__2C3393D0

alter table persons
	add constraint DF_Persons_City DEFAULT ('Jakarta') FOR CITY
go

alter table persons
	drop constraint DF_persons_City
go

alter table persons
	add constraint DF_Persons_City DEFAULT ('Jakarta') FOR CITY

ALTER TABLE PERSONS
	ALTER COLUMN CITY VARCHAR(500) NOT NULL
go

ALTER TABLE PERSONS
	DROP COLUMN Aamat

-- DDL menghapus object database
DROP TABLE persons

--DCL
--> // memberikan akses
GRANT select ON Orders TO penjual
GRANT select ON Persons TO penjual

--> // Mengambil kembali akses(menolak akses)
REVOKE UPDATE on persons from penjual
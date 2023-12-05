CREATE DATABASE DB_KARYAWAN

USE DB_KARYAWAN
																
create table Biodata(
	id int not null,
	first_name varchar(20),
	last_name varchar(30),
	dob varchar(10),
	pob varchar(50),
	address varchar(255),
	marital_status bit,

	constraint pk_Biodata primary key(ID)
)

INSERT INTO BIODATA
VALUES	(1, 'Raya', 'Indriyani', '1991-01-01', 'Bali', 'Jl. Raya Baru, Bali', 0),
		(2, 'Rere', 'Wulandari', '1992-01-02', 'Bandung', 'Jl. Berkah Ramadhan, Bandung', 0),
		(3, 'Bunga', 'Maria', '1991-03-03', 'Jakarta', 'Jl. Mawar Semerbak, Bogor', 1),
		(4, 'Natasha', 'Wulan', '1990-04-01', 'Jakarta', 'Jl. Mawar Harum, Jakarta', 0),
		(5, 'Zahra', 'Aurelia Putri', '1991-03-03', 'Jakarta', 'Jl. Mawar Semerbak, Bogor', 1),
		(6, 'Katniss', 'Everdeen', '1989-01-12', 'Jakarta', 'Jl. Bunga Melati, Jakarta', 1)

SELECT * FROM Biodata
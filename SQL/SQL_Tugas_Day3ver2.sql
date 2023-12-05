CREATE DATABASE DB_Univ_XA

USE DB_Univ_XA

CREATE TABLE Mahasiswa(
	Nim varchar(50) not null,
	nama varchar(50) not null,
	jenis_kelamin varchar(50) not null,
	alamat varchar(50) not null,

	constraint pk_Mahasiswa primary key(Nim)
)

INSERT INTO Mahasiswa
values	('101', 'Arif', 'L', 'Jl. Kenangan'),
		('102', 'Budi', 'L', 'Jl. Jombang'),
		('103', 'Wati', 'P', 'Jl. Surabaya'),
		('104', 'Ika', 'P', 'Jl. Jombang'),
		('105', 'Tono', 'L', 'Jl. Jakarta'),
		('106', 'Iwan', 'L', 'Jl. Bandung'),
		('107', 'Sari', 'P', 'Jl. Malang')

CREATE TABLE Matakuliah(
	kode_mk varchar(50) not null,
	nama_mk varchar(100) not null,
	sks int,
	semester int,

	constraint pk_Matakuliah primary key(kode_mk)
)

Insert into Matakuliah
values	('PTI447', 'Praktikum Basis Data', 1, 3),
		('TIK342', 'Praktikum Basis Data', 1, 3),
		('PTI333', 'Basis Data Terdistribusi', 3, 5),
		('TIK123', 'Jaringan Komputer', 2, 5),
		('TIK333', 'Sistem Operasi', 3, 5),
		('PTI123', 'Grafika Multimedia', 3, 5),
		('PTI777', 'Sistem Informasi', 2, 3)

CREATE TABLE ambil_mk(
	nim varchar(50) not null,
	kode_mk varchar(50) not null,

	constraint pk_ambil_mk primary key(kode_mk)
)

INSERT INTO ambil_mk
values	('101', 'PTI447'),
		('103', 'TIK333'),
		('104', 'PTI333'),
		('104', 'PTI777'),
		('111', 'PTI123'),
		('123', 'PTI999')

Select * from Mahasiswa
Select * from Matakuliah
Select * from ambil_mk

--SOAL No1
Select ms.nama, mk.nama_mk
from Mahasiswa as ms INNER JOIN ambil_mk as a
ON ms.Nim=a.nim
INNer join Matakuliah as mk
ON a.kode_mk = mk.kode_mk

--SOAL NO2
Select ms.Nim, ms.nama, ms.jenis_kelamin, ms.alamat
from Mahasiswa as ms left outer JOIN ambil_mk as a
ON ms.Nim=a.nim
left outer join Matakuliah as mk
ON a.kode_mk = mk.kode_mk
Where mk.kode_mk is NULL

--SOAL NO3
Select count(ms.jenis_kelamin) jml, ms.jenis_kelamin
from Mahasiswa as ms left outer JOIN ambil_mk as a
ON ms.Nim=a.nim
left outer join Matakuliah as mk
ON a.kode_mk = mk.kode_mk
Where mk.kode_mk is NULL
Group by ms.jenis_kelamin

--SOAL NO4
Select ms.nama, mk.kode_mk, mk.nama_mk
from Mahasiswa as ms inner JOIN ambil_mk as a
ON ms.Nim=a.nim
inner join Matakuliah as mk
ON a.kode_mk = mk.kode_mk

--SOAL NO5
Select ms.Nim, ms.nama, sum(mk.sks) as jmlh_sks
from Mahasiswa as ms 
INNER JOIN ambil_mk as a ON ms.Nim=a.nim
INNER join Matakuliah as mk ON a.kode_mk = mk.kode_mk
group by  ms.Nim, ms.nama
having sum(mk.sks) > 4 and sum(mk.sks)<10

--SOAL No6
Select mk.nama_mk
from Mahasiswa as ms 
right JOIN ambil_mk as a ON ms.Nim=a.nim
right join Matakuliah as mk ON a.kode_mk = mk.kode_mk
WHERE ms.nama is null
order by mk.sks

--NO. 3 bikin function
go
CREATE FUNCTION fn_jenis_kelamin_id(@jenis_kelamin varchar)
returns table
AS
return(

	Select  ms.jenis_kelamin, COUNT(ms.jenis_kelamin) jmlh
	from Mahasiswa as ms left outer JOIN ambil_mk as a
	ON ms.Nim=a.nim
	left outer join Matakuliah as mk
	ON a.kode_mk = mk.kode_mk
	Where mk.kode_mk is NULL and ms.jenis_kelamin = @jenis_kelamin
	Group by ms.jenis_kelamin
	
	
)
go

drop function fn_jenis_kelamin_id
select * from dbo.fn_jenis_kelamin_id('p')


--soal no 4
create procedure usp_mahasiswa
	@nim int
as
	select M.nim, m.nama, a.kode_mk, mk.nama_mk
	from Mahasiswa m inner join ambil_mk as a on m.Nim=a.nim
	inner join Matakuliah mk On a.kode_mk=mk.kode_mk
	where m.Nim = @nim
go
usp_mahasiswa 103
go

create procedure usp_mahasiswa_by_name
	@nama varchar(10)
as
	select M.nim, m.nama, a.kode_mk, mk.nama_mk
	from Mahasiswa m inner join ambil_mk as a on m.Nim=a.nim
	inner join Matakuliah mk On a.kode_mk=mk.kode_mk
	where m.nama like '%'+@nama+'%'

usp_mahasiswa_by_name 'ar'

drop proc usp_mahasiswa_by_name


--soal no6
create procedure usp_null
	@nama_mk varchar
as
	Select mk.nama_mk
	from Mahasiswa as ms 
	right JOIN ambil_mk as a ON ms.Nim=a.nim
	right join Matakuliah as mk ON a.kode_mk = mk.kode_mk
	WHERE @nama_mk
	order by mk.sks
go

drop proc usp_null

create proc usp_mk_mahasiswa
	@nama_mhs varchar(50)
AS
	Select ms.nama, mk.nama_mk
	from Mahasiswa as ms 
	full JOIN ambil_mk as a ON ms.Nim=a.nim
	full join Matakuliah as mk ON a.kode_mk = mk.kode_mk
	WHERE ms.nama like '%'+ @nama_mhs +'%'

usp_mk_mahasiswa 'arif'
	
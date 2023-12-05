CREATE DATABASE DBPenerbit

USE DBPenerbit
go

CREATE TABLE tblPengarang(
	ID int identity (1,1)not null,
	Kd_Pengarang Varchar(7) not null,
	Nama varchar (30) not null,
	Alamat varchar (80) not null,
	kota varchar (15) not null,
	KELAMIN varchar (1) not null,

	constraint PK_tbl_Pengarang primary key (ID)
)

INSERT INTO tblPengarang (Kd_Pengarang, Nama, Alamat, kota, KELAMIN)
Values  ('P0001',	'Ashadi',	'Jl. Beo 25		',	'Yogya',	'P'),
		('P0002',	'Rian',		'Jl. Solo 123	',	'Yogya',	'P'),
		('P0003',	'Suwadi',	'Jl. Semangka 13',	'Bandung',	'P'),
		('P0004',	'Siti',		'Jl. Durian 15',	'Solo',		'W'),
		('P0005',	'Amir',		'Jl. Gajah 33	',	'Kudus',	'P'),
		('P0006',	'Suparman',	'Jl. Harimau 25	',	'Jakarta',	'P'),
		('P0007',	'Jaja',		'Jl. Singa 7',		'Bandung',	'P'),
		('P0008',	'Saman',	'Jl. Naga 12',		'Yogya',	'P'),
		('P0009',	'Anwar',	'Jl. Tidar 6A',		'Magelang',	'P'),
		('P0010',	'Fatmawati','Jl. Renjana 4	',	'Bogor',	'W')

select * from tblPengarang

CREATE TABLE tblGaji(
	ID int identity (1,1)not null,
	Kd_Pengarang Varchar(7) not null,
	Nama varchar (30) not null,
	Gaji decimal (18,4) not null

	constraint PK_tbl_Gaji primary key (ID)
)

INSERT INTO tblGaji (Kd_Pengarang, Nama, Gaji)
Values  ('P0002',	'Rian',			600000 ),
		('P0005',	'Amir',			700000	),
		('P0004',	'Siti',			500000	),
		('P0003',	'Suwadi',		1000000),
		('P0010',	'Fatmawati',	600000	),
		('P0008',	'Saman',		750000	)

select * from tblGaji

/* BETWEEN -->  Ranged Values
	data yg ditentukan awal dan akhirnya

	WHERE <field>
*/

--SOAL NO1
select count (nama) as jml_pengarang
from tblPengarang

--SOALNO2
select kelamin, count (kelamin) as jmlh_kelamin
from tblPengarang
group by kelamin

--SOAL NO3
select kota, count(kota)as jmlh_kota 
from tblPengarang
group by kota

--SOAL NO4
select kota, count(kota)as jmlh_kota 
from tblPengarang
group by kota
having count(kota) > 1

--SOAL NO5
select MAX(kd_pengarang) kd_pengarang_max, MIN(kd_pengarang) kd_pengarang_min
from tblPengarang

--SOAL NO6
select max(gaji) gaji_tertinggi, MIN(gaji) Gaji_terendah
from tblGaji

--SOAL NO7
select nama, gaji
from tblGaji
where gaji > 600000

--SOAL NO8
select sum(gaji) jumlah_gaji from tblGaji

--SOAL NO9
select p.kota, G.Gaji 
from tblPengarang as P INNER JOIN tblGaji as G 
	ON p.Kd_Pengarang = G.Kd_Pengarang

select p.kota,sum(G.Gaji) as total_gaji 
from tblPengarang as P INNER JOIN tblGaji as G 
	ON p.Kd_Pengarang = G.Kd_Pengarang
group by p.kota

--SOAL NO 10
select * from tblPengarang
where Kd_Pengarang BETWEEN 'P0003' AND 'P0006'

select * from tblPengarang
where Kd_Pengarang >= 'P0003' AND Kd_Pengarang <= 'P0006'

--SOAL NO 11
select * from tblPengarang
where Kota = 'yogya' or kota = 'solo' or kota = 'magelang'

select * from tblPengarang
WHERE kota IN('yogya', 'solo', 'magelang')

--SOAL NO 12
select * FROM tblPengarang
WHERE NOT Kota = 'yogya'

select * FROM tblPengarang
WHERE Kota <> 'yogya'

select * FROM tblPengarang
WHERE Kota != 'yogya'

--SOAL NO13
--a. dimulai dengan huruf [A]
select * from tblPengarang WHERE Nama like 'A%'
select * from tblPengarang WHERE Nama like 'a%'
COLLATE SQL_Latin1_General_CP1_CS_AS --Menjadikan CASE sensitive
--b. berakhiran [i]
select * from tblPengarang WHERE Nama like '%I'
--c. huruf ketiganya [a]
select * from tblPengarang WHERE nama like '__a%'
--d. tidak berakhiran [n]	
select * from tblPengarang WHERE nama NOT LIKE 'n%'

--SOAL NO 14
select * from tblPengarang as P
	INNER JOIN tblGaji as G 
	ON P.Kd_Pengarang=G.Kd_Pengarang

--SOAL NO 15
select P.kota, G.Gaji
FROM tblPengarang as P INNER JOIN tblGaji as G ON P.Kd_Pengarang = G.Kd_Pengarang
WHERE G.Gaji < 1000000

--SOAL NO 16
SP_help tblPengarang
ALTER TABLE tblPengarang
	ALTER COLUMN Kelamin VARCHAR(1)

--SOAL NO 17
ALTER TABLE tblPengarang
	ADD Gelar VARCHAR(12)

--SOAL NO 18
select * from tblPengarang where Nama = 'rian'
UPDATE tblPengarang
	set Alamat = 'Jl. Cendrawasih 65', kota = 'Pekanbaru'
WHERE Nama = 'rian'

--SOAL NO 19
CREATE VIEW vm_Pengarang
as
	SELECT P.Kd_Pengarang, P.NAMA, P.kota, G.Gaji
	FROM tblPengarang as P INNER JOIN tblGaji as G
	ON P.Kd_Pengarang = G.Kd_Pengarang
GO

select * from vm_Pengarang

select * from tblPengarang
where KELAMIN Like 'p'

select * from tblPengarang
where Nama like '____'

USE XPOS329
go
/* AGGREGATE
	Mengelompokkan data
	- SUM	: Menghasilkan jumlah total dari data yang dikelompokkan
	- MAX	: Menghasilkan data yang memiliki nilai terbesar dari data yang dikelompokkan
	- MIN	: Menghasilkan data yang memiliki nilai terkecil dari data yang dikelompokkan
	- AVG	: Menghasilkan data yang memiliki nilai Rata-rata dari data yang dikelompokkan
	- COUNT : Menghasilkan jumlah data yang 
*/

/* CONCATENATE
	Penggabungan beberapa field / teks menjadi satu

	Cara-1:
		CONCAT (<field_1/teks_1>, <field_2/teks_2>,....., <field_n/teks_n>)
	Cara-2:
		<field_1/teks_1> + <field_2/teks_2> + .... + <field_n/teks_n>
*/

/* Wildcard character (*, %, _ )
	* : semua field / column
	% : semua teks
	_ : Hanya 1 karakter
*/

--menggabungkan firstname dan lastname menggunakan concat
select CONCAT(firstname , ' ', LAstname) full_Name, Age, City 
into new_person
from persons

--mencari nama yang memiliki 5 karakter
select * from new_person
where full_Name like '% _____'

use Northwind
go

select* from Employees

select title, count(title) count_title 
from Employees
group by title

select* from Employees

/*  ORDER BY : MENGURURTKAN DATA
	select... from....where... group by.... having
	ORDER BY <field_nama> [ASC] [DECS]
	ASC : mengurutkan dari yg terkecil hingga terbesar
	DESC : mengururtkan dari yang terbesar hingga yang terkecil
*/
--ORDER BY
select customerID, Freight
from ORDERS
order by freight

select min(freight) as least_freight, max(freight) most_freigt
from orders

/* HAVING: Mengurutkan data setelah diaggregate (dikelompokkan)
	select... from ... where ... group by ...
	HAVING <kondisi_perbandingan>
*/
-- HAVING
select customerID, SUM(freight) Total_freight
from orders
group by customerID
having sum(freight) > 500
order by SUM(Freight)

/* CASE-WHEN-ELSE : Percabangan nilai field / column
	CASE WHEN <field_name> <operator_perbandingan> <nilai_pembanding_1>
		THEN <proses_ketika_TRUE>
	WHEN <field_name> <operator_perbandingan> <nilai_pembanding_N>
		THEN <proses_ketika_TRUE>
		ELSE <proses_ketika_FALSE>
	END <field_nama>
*/
--CASE WHEN ELSE
USE DBPenerbit
go
select 
	case WHEN kelamin = 'p'
		THEN 'Pria'
	WHEN Kelamin = 'W'
		THEN 'WANITA'
	WHEN Kelamin = 'L'
		THEN 'LAKI_LAKI'
	END Kelamin,
	count(kelamin) jmlh_kelamin
from tblPengarang
group by kelamin
/*  IN : Mencari data dari sebuah daftar terhadap sebuah field/column/nilai
	SELECT ... 
	WHERE ... <field/column/nilai> IN(<nilai_1>, ... , <nilai_n>)
*/
select * from tblPengarang
WHERE KOTA IN ('Bogor', 'Bandung')

select * from tblPengarang
WHERE KOTA IN ('Bogor', 'Bandung')

/* JOIN : Mendapatkan irisan dari 2 tabel atau lebih
	1. INNER JOIN : Data dari irisan kedua table
	2. FULL JOIN  : Seluruh data dari kedua table
	3. RIGHT JOIN : Seluruh data dari table sebelah kanan ditambah data dari irisan kedua table
	4. LEFT JOIN  :	Seluruh data dari table sebelah kiri ditambah data dari irisan kedua table
*/
SELECT Kd_Pengarang, Nama, Kota FROM tblPengarang
SELECT Kd_Pengarang, Nama, Gaji FROM tblGaji

SELECT P.Kd_Pengarang, P.Nama, P.kota, G.Gaji
FROM tblPengarang as P 
	INNER JOIN tblGaji as G ON P.Kd_Pengarang = G.Kd_Pengarang

SELECT P.Kd_Pengarang, P.Nama, P.kota, G.Gaji
FROM tblPengarang as P 
	FULL OUTER JOIN tblGaji as G ON P.Kd_Pengarang = G.Kd_Pengarang
WHERE P.Kd_Pengarang IS NULL OR G.Kd_Pengarang IS NULL

SELECT P.Kd_Pengarang, P.Nama, P.kota, G.Kd_Pengarang, G.Nama, G.Gaji
FROM tblPengarang as P 
	RIGHT JOIN tblGaji as G ON P.Kd_Pengarang = G.Kd_Pengarang

SELECT P.Kd_Pengarang, P.Nama, P.kota, G.Kd_Pengarang, G.Nama, G.Gaji
FROM tblPengarang as P 
	LEFT JOIN tblGaji as G ON P.Kd_Pengarang = G.Kd_Pengarang

/* TOP x : Menampilkan hanya x record dari record teratas.
	SELECT TOP <jumlah_record>...
*/

/* UNION : Menggabungkan beberapa table maenjda satu dengan syarat Sbb:
	1. Jumlah Column antar table harus sama
	2. DataType column pada masing" table harus sama.
	3. order by hanya dapat digunakan pada akhir query
	3. Jenis isi datanya sama (opsional).
*/
use Northwind
go

SELECT *FROM (
	select top 5 CustomerID, freight
	from Orders
	order by Freight DESC
)max_freight
union all
select * from (
	select top 5 CUstomerID, freight
	from Orders
order by Freight
)min_freight

SELECT *FROM (
	select top 5 CustomerID, freight
	from Orders
	order by Freight DESC
)max_freight
union
select * from (
	select top 5 CUstomerID, freight
	from Orders
order by Freight
)min_freight
GO

/* VIEW: suatu table temporary yang menyimpan query
	CREATE VIEW<nama_view>
	AS
		<QUERY>

*/
CREATE VIEW vm_minmax_customer_freight
AS
	SELECT *FROM (
	select top 1 CustomerID, freight
	from Orders
	order by Freight DESC
	)max_freight
	union all
	select * from (
	select top 1 CUstomerID, freight
	from Orders
	order by Freight
	)min_freight

SELECT * FROM vm_minmax_customer_freight


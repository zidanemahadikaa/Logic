CREATE DATABASE DB_HR

use DB_HR

CREATE TABLE tb_karyawan(
	id BIGINT identity (1,1) not null,
	nip varchar(50) not null,
	nama_depan varchar (50) not null,
	nama_belakang varchar(50) not null,
	jenis_kelamin varchar (50) not null,
	agama varchar(50) not null,
	tempat_lahir varchar(50) not null,
	tgl_lahir date,
	alamat varchar(100) not null,
	pendidikan_terakhir varchar(50) not null,
	tgl_masuk date

	constraint pk_tb_karyawan primary key (id)
)

insert into tb_karyawan
values	('001', 'Hamidi', 'Samsudin', 'Pria', 'Islam', 'Sukabumi', '1977-04-21', 'Jl. Sudirman No.12', 'S1 Teknik Mesin', '2015-12-07'),
		('003', 'Paul', 'Christian', 'Pria', 'Kristen', 'Ambon', '1980-05-27', 'Jl. Veteran No.4', 'S1 Pendidikan Geografi', '2014-01-12'),
		('002', 'Ghandi', 'Wamida',	'Wanita', 'Islam', 'Palu', '1992-01-12', 'Jl. Rambutan NO.22', 'SMA Negeri 02 Palu', '2014-12-01')

CREATE TABLE tb_divisi(
	id bigint identity(1,1) not null,
	kd_divisi varchar(50) not null,
	nama_divisi varchar(50) not null,

	constraint pk_tb_divisi primary key (id)
)

insert into tb_divisi
values  ('GD', 'Gudang'),
		('HRD', 'HRD'),
		('KU', 'Keuangan'),
		('UM', 'Umum')

CREATE TABLE tb_jabatan(
	id BIGINT identity (1,1) not null,
	kd_jabatan varchar(50) not null,
	nama_jabatan varchar (50) not null,
	gaji_poko numeric,
	tunjangan_jabatan numeric,

	constraint pk_tb_jabatan primary key (id)
)

INSERT INTO tb_jabatan
values	('MGR', 'Manager', 5500000, 1500000),
		('OB', 'Office Boy', 1900000, 200000),
		('ST', 'Staff', 3000000, 750000),
		('WMGR', 'Wakil Manager', 4000000, 1200000)

CREATE TABLE tb_pekerjaan(
	id BIGINT identity (1,1) not null,
	nip varchar(50) not null,
	kode_jabatan varchar (50) not null,
	kode_divisi varchar(50) not null,
	tunjangan_kinerja numeric,
	kota_penetapan varchar(50)

	constraint pk_tb_pekerjaan primary key (id)
)

insert into tb_pekerjaan
values  ('001', 'ST', 'KU', 750000, 'Cianjur'),
		('002', 'OB', 'UM', 350000, 'Sukabumi'),
		('003', 'MGR', 'HRD', 1500000, 'Sukabumi')

select * from tb_karyawan
select * from tb_jabatan
select * from tb_pekerjaan


--SOAL NO1
select k.nama_depan + '' + k.nama_belakang as nama_lengkap,
j.nama_jabatan, j.gaji_poko + j.tunjangan_jabatan as gaji_tunjangan
from tb_karyawan as k 
Inner join tb_pekerjaan as p
on k.nip = p.nip
inner join tb_jabatan as j
on j.kd_jabatan = p.kode_jabatan
Where j.gaji_poko + p.tunjangan_kinerja < 5000000

--SOAL NO2
select k.nama_depan + '' + k.nama_belakang as nama_lengkap,
j.nama_jabatan, d.nama_divisi,
j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja as total_gaji,
(j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja)*0.05 as pajak,
(j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja)-
((j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja)*0.05) as gaji_bersih
from tb_karyawan as k 
Inner join tb_pekerjaan as p on k.nip = p.nip
inner join tb_jabatan as j on p.kode_jabatan=j.kd_jabatan 
inner join tb_divisi as d on p.kode_divisi = d.kd_divisi
WHERE k.jenis_kelamin = 'pria' and p.kota_penetapan != 'sukabumi'

--SOAL NO3
select k.nip, k.nama_depan+' '+k.nama_belakang as nama_lengkap,
j.nama_jabatan, d.nama_divisi,
FORMAT(((g.gaji_total)*7)* 0.25, 'RP\. #,0.00') as bonus
from tb_jabatan as j
inner join #temp_gaji as g on j.kd_jabatan = g.kd_jabatan
Inner join tb_pekerjaan as p on g.kd_jabatan = p.kode_jabatan
inner join tb_divisi as d on p.kode_divisi = d.kd_divisi
inner join tb_karyawan as k on p.nip = k.nip
order by k.nip

select * from #temp_gaji

--SOAL NO 4
select k.nip, k.nama_depan+' '+k.nama_belakang as nama_lengkap,
j.nama_jabatan, d.nama_divisi,
j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja as total_gaji,
(j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja)*0.05 as infak
from tb_karyawan as k 
Inner join tb_pekerjaan as p on k.nip = p.nip
inner join tb_jabatan as j on j.kd_jabatan = p.kode_jabatan
inner join tb_divisi as d on p.kode_divisi = d.kd_divisi
where j.nama_jabatan = 'Manager'

--SOAL NO5
select k.nip, k.nama_depan+' '+k.nama_belakang as nama_lengkap,
j.nama_jabatan, k.pendidikan_terakhir,
2000000 as tunjangan_pendidikan,
j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja as total_gaji
from tb_karyawan as k 
Inner join tb_pekerjaan as p on k.nip = p.nip
inner join tb_jabatan as j on j.kd_jabatan = p.kode_jabatan
inner join tb_divisi as d on p.kode_divisi = d.kd_divisi
WHERE k.pendidikan_terakhir like 'S1%'
order by nip

--SOAL NO6
select k.nip, k.nama_depan+' '+k.nama_belakang as nama_lengkap,
j.nama_jabatan,d.nama_divisi,
	case
		when j.kd_jabatan = 'mgr' then g.gaji_total*7/4
		when j.kd_jabatan = 'ST' then g.gaji_total*5/4
		else g.gaji_total*2/4
	end as bonus
from tb_karyawan as k 
Inner join tb_pekerjaan as p on k.nip = p.nip
inner join tb_jabatan as j on j.kd_jabatan = p.kode_jabatan
inner join tb_divisi as d on p.kode_divisi = d.kd_divisi
inner join #temp_gaji as g on j.kd_jabatan = g.kd_jabatan

--SOAL NO7
ALTER TABLE tb_karyawan
	add constraint u_karyawan_nip unique (nip)

--SOAL NO8
CREATE INDEX idx_tb_karyawan_nip on tb_karyawan(nip)

--SOAL NO9
select  
	CONCAT(nama_depan, ' ', 
	case when nama_belakang like 'w%' then UPPER(nama_belakang) else nama_belakang end
	) as nama_lengkap
from tb_karyawan

--SOAL NO10
select k.nama_depan+' '+k.nama_belakang as nama_lengkap,
k.tgl_masuk, j.nama_jabatan, d.nama_divisi,
g.gaji_total as total_gaji,
DATEDIFF(YEAR, k.tgl_masuk, DATEADD(YEAR, -1, GETDATE())) as lama_bekerja
from tb_karyawan as k 
Inner join tb_pekerjaan as p on k.nip = p.nip
inner join tb_jabatan as j on j.kd_jabatan = p.kode_jabatan
inner join tb_divisi as d on p.kode_divisi = d.kd_divisi
inner join #temp_gaji as g on j.kd_jabatan = g.kd_jabatan
WHERE DATEDIFF(year, k.tgl_masuk, GETDATE()) >=9


sp_help tb_karyawan

/* TEMPORARY TABLE : Sebuah table sementara

*/

CREATE TABLE #temp_gaji(
	kd_jabatan varchar(50),
	gaji_total money
)

INSERT INTO #temp_gaji
select j.kd_jabatan, (j.gaji_poko+j.tunjangan_jabatan+p.tunjangan_kinerja)
from tb_karyawan k 
inner join tb_pekerjaan p ON k.nip=p.nip
INNER JOIN tb_jabatan j ON p.kode_jabatan=j.kd_jabatan

/** STRING FORMAT : untuk menentukan format string
	FORMAT (<field_name/nilai>, <fortmat_string>)
*/

DECLARE	 @tanggal DATETIME
DECLARE @angka money

SET @tanggal = GETDATE()
SET @angka = 12345.6789

select @tanggal date_time, FORMAT (@tanggal, 'dd/MM/yyyy HH:mm:ss') dd_mm_yyyy, FORMAT (@tanggal, 'dd/MM/yyyy HH:mm:ss') dd_mm_yyyy
select @angka angka_pecahan, FORMAT(@angka, '0#.##') angka_pecahan_2desimal

/*
interval	Required. The part to return. Can be one of the following values:
				year, yyyy, yy = Year
				quarter, qq, q = Quarter
				month, mm, m = month
				dayofyear = Day of the year
				day, dy, y = Day
				week, ww, wk = Week
				weekday, dw, w = Weekday
				hour, hh = hour
				minute, mi, n = Minute
				second, ss, s = Second
				millisecond, ms = Millisecond
*/

/* DATEADD() : Menambahkan suatu interval waktu terhadap DATETIME
	- DATEADD(<interval>, <nilai_yg mau_ditambahkan>, <field/datetime>)
*/

SELECT GETDATE() today, DATEADD(day, 1, GETDATE()) tomorrow, DATEADD(month, 1, GETDATE()) next_month

/* DATEDIFF() : Mencari selisih dari 2 DATETIME
	- DATEDIFF(<interval>, <datetime_awal>, <datetime_akhir>)
*/

SELECT GETDATE() today, DATEDIFF(DAY, GETDATE(), DATEADD(WEEK, 1, GETDATE())) days_DIFFERENCE
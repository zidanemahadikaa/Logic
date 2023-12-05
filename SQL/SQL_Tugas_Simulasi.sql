CREATE DATABASE DB_PTXA

use DB_PTXA

create table biodata(
	id bigint not null,
	first_name varchar(20),
	last_name varchar(30),
	dob datetime,
	pob varchar(50),
	address varchar(255),
	gender varchar(1),

	constraint pk_biodata primary key(id)
)

insert into biodata
values	(1, 'Soraya', 'Rahayu', '1990-12-22', 'Bali', 'Jl. Raya Kuta, Bali', 'P'),
		(2, 'Hanum', 'Danuary', '1990-01-02', 'Bandung', 'Jl. Berkah Ramadhan, Bandung', 'P'),
		(3, 'Melati', 'Marcelia', '1991-03-03', 'Jakarta', 'Jl. Mawar 3, Brebes', 'P'),
		(4, 'Farhan', 'Djokrowidodo', '1989-10-11', 'Jakarta', 'Jl. Bahari Raya, Solo', 'L')

Create table employee(
	id bigint not null,
	biodata_id bigint,
	nip varchar(5),
	status varchar(10),
	join_date datetime,
	salary decimal(10,0),

	constraint pk_employee primary key (id)
)

insert into employee
values	(1, 1, 'XA001', 'Permanen', '2015-11-01 00:00:00.000', 12000000),
		(2, 2, 'XA002', 'Kontrak',  '2017-01-02 00:00:00.000',  10000000),
		(3, 3, 'XA003', 'Kontrak',  '2018-08-19 00:00:00.000',  10000000)

Create table contact_person(
	id bigint,
	biodata_id bigint,
	type varchar(5),
	contact varchar(100)

	constraint pk_contact_person primary key(id)
)

insert into contact_person
values	(1, 1, 'MAIL', 'soraya.rahayu@gmail.com'),
		(2, 1, 'PHONE', '085612345678'),
		(3, 2, 'MAIL', 'hanum.danuary@gmail.com'),
		(5, 2, 'PHONE', '081312345678'),
		(4, 2, 'PHONE', '087812345678'),
		(6, 3, 'MAIL', 'melati.marcelia@gmail.com')

create table Leave(
	id bigint,
	type varchar(10),
	nama varchar(100)

	constraint pk_Leave primary key (id)
)

insert into Leave
values	(1, 'Reguler', 'Cuti Tahunan'),
		(2, 'Khusus', 'Cuti Menikah'),
		(3, 'Khusus', 'Cuti Haji & Umroh'),
		(4, 'Khusus', 'Melahirkan')

create table employee_leave(
	id int,
	employee_id int,
	period varchar(4),
	regular_quota int,

	constraint pk_employee_leave primary key(id)
)

insert into employee_leave
values	(1, 1, '2021',16),
		(2, 2, '2021',12),
		(3, 3, '2021',12)

create table leave_request(
	id bigint,
	employee_id bigint,
	leave_id bigint,
	start_date date,
	end_date date,
	reason VARCHAR(255),

	constraint pk_leave_request primary key(id)
)

insert into leave_request
values	(1, 1, 1, '2021-10-10', '2021-10-12', 'Liburan'),
		(2, 1, 1, '2021-11-12', '2021-11-15', 'Acara Keluarga'),
		(3, 2, 2, '2021-05-05', '2021-05-07', 'Menikah'),
		(4, 2, 1, '2021-09-09', '2021-09-13', 'Touring'),
		(5, 2, 1, '2021-12-20', '2021-12-23', 'Acara keluarga')

--1. Menampilkan karyawan yang pertama kali masuk.								
select top 1
	e.nip, b.first_name,
	DATEDIFF(YEAR, e.join_date, GETDATE()) lama_kerja,
	FORMAT (join_date, 'MMMM') bulang_bergabung
from biodata as b inner join employee as e on b.id=e.biodata_id
order by lama_kerja

--2. Menampilkan daftar karyawan yang saat ini sedang cuti. Daftar berisi nomor_induk, nama, tanggal_mulai, lama_cuti dan keterangan.								
select e.nip, b.first_name,
	lr.start_date, DATEDIFF(DAY, lr.start_date, lr.end_date) as lama_cuti,
	lr.reason
from biodata as b inner join employee as e on b.id = e.biodata_id
inner join leave_request as lr on e.id=lr.employee_id
where '2021-12-22' between lr.start_date and lr.end_date

--3. Menampilkan daftar karyawan yang sudah mengajukan cuti lebih dari 2 kali. Tampilkan data berisi no_induk, nama, jumlah pengajuan .								
select e.nip, b.first_name +' '+ b.last_name, count(e.nip) jmlh_pengajuan
from biodata as b inner join employee as e on b.id = e.biodata_id
inner join leave_request as lr on e.id=lr.employee_id
group by e.nip, b.first_name

--4. Menampilkan sisa cuti tiap karyawan tahun ini, jika di ketahui jatah cuti setiap karyawan tahun ini adalah sesuaidengan quota cuti. tampilan berisi no_induk, nama, quota, cuti yg sudah di ambil dan sisa_cuti														
select e.nip, b.first_name +' '+ b.last_name fullname, el.regular_quota,
	SUM(lr.lama_cuti) as banyak_cuti,
	el.regular_quota - SUM(lr.lama_cuti) as sisa_cuti
from biodata b inner join employee e on b.id=e.biodata_id
inner join employee_leave as el on e.id=el.employee_id
inner join (
	select lr.employee_id, DATEDIFF(day, lr.start_date, lr.end_date) lama_cuti
	from leave_request lr
	)as lr on e.id=lr.employee_id
group by e.nip, b.first_name, b.last_name, el.regular_quota

select e.nip, b.first_name +' '+ b.last_name fullname, employee_id,
	DATEDIFF(day, start_date, end_date) lama_cuti,
	lr.start_date, lr.end_date
from leave_request lr inner join employee e on lr.employee_id=e.id
inner join biodata as b on e.biodata_id=b.id
order by e.id

--5. Perusahaan akan meberikan bonus bagi karyawan yang sudah bekerja lebih dari 5 tahun sebanyak 1.5 kali gaji. Tampilan No induk, Fullname, Berapa lama bekerja, Bonus, Total Gaji(gaji + bonus)													
select
	e.nip, b.first_name,
	DATEDIFF(YEAR, e.join_date, GETDATE()) lama_kerja,
	e.salary*1.5 as bonus,
	e.salary+(e.salary*1.5) as total_gaji
from biodata as b inner join employee as e on b.id=e.biodata_id
where DATEDIFF(YEAR, e.join_date, GETDATE()) > 5

--6. Tampilkan nip, nama_lengkap, jika karyawan ada yg berulang tahun di hari ini akan diberikan hadiah
--bonus sebanyak 5% dari gaji jika tidak ulang tahun maka bonus 0 dan total gaji . Tampilkan No Induk, nama, Tgl lahir , Usia, Bonus, Total Gaji
select e.nip, b.first_name +' '+ b.last_name fullname,
	b.dob, DATEDIFF(year, b.dob, '2021-12-22') as Usia,
	case when month(b.dob)=MONTH('2021-12-22') and DAY(b.dob)=DAY('2021-12-22')
		then e.salary*0.5
		else 0
	end bonus,
	case when month(b.dob)=MONTH('2021-12-02') and DAY(b.dob)=DAY('2021-12-22')
		then e.salary*1.5
		else e.salary
	end total_gaji
from biodata as b inner join employee as e on b.id=e.biodata_id

--7. Tampilkan No Induk, nama, Tgl lahir , Usia. Urutkan biodata dari yg paling muda sampai yg tua																
select e.nip, b.first_name +' '+ b.last_name fullname,
	format (b.dob,'d', 'id-ID'), DATEDIFF(year, b.dob, '2021-12-22') as Usia
from biodata as b inner join employee as e on b.id=e.biodata_id
order by usia

--8. Tampikan Karyawan yg belum pernah Cuti						
select e.nip, b.first_name +' '+ b.last_name fullname
from employee e left join leave_request as lr on e.id=lr.employee_id
inner join biodata b on e.biodata_id=b.id
where lr.reason is null

--9. Tampikan Nama Lengkap, Jenis Cuti, Durasi Cuti, dan no telp yang sedang cuti							
select b.first_name +' '+ b.last_name fullname, l.type jenis_cuti, 
	DATEDIFF(day, lr.start_date, lr.end_date) durasi_cuti, 
	cp.contact
from biodata as b inner join employee as e on b.id=e.biodata_id
inner join leave_request as lr on e.id=lr.employee_id
inner join Leave as l on lr.leave_id = l.id
inner join contact_person cp on b.id=cp.biodata_id
where cp.type = 'phone' and '2021-12-22' between lr.start_date and lr.end_date
group by b.first_name, b.last_name, cp.contact, 
lr.start_date, lr.end_date, l.type

--10. Tampilkan nama-nama pelamar yang tidak diterima sebagai karyawan					
select  b.first_name +' '+ b.last_name fullname
from biodata as b left join employee as e on b.id = e.biodata_id
where e.nip is null

--11. buatlah sebuah view yg menampilkan data nama lengkap, tgl lahir dan tmpat lahir , status, dan salary						
go
CREATE VIEW vw_profil as
select  b.first_name +' '+ b.last_name fullname,
		b.dob as tgl_lahir, b.pob, e.status, e. salary
from biodata b inner join employee e on b.id=e.biodata_id

select * from vw_profil
--12. Tampilkan  alasan cuti yang paling sering diajukan										
select top 1
	lr.reason, COUNT(lr.reason) banyak_cuti
from leave_request lr inner join Leave l on lr.leave_id=l.id
group by lr.reason
order by banyak_cuti desc

select 
	lr.reason, COUNT(lr.reason) banyak_cuti
from leave_request lr inner join employee e on lr.employee_id = e.id
inner join Leave l on lr.leave_id=l.id
group by lr.reason
having count (lr.reason) = (
	select  top 1
	COUNT(lr.reason) banyak_cuti
	from leave_request lr inner join Leave l on lr.leave_id=l.id
	group by lr.reason
	order by banyak_cuti desc
)

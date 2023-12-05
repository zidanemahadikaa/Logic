CREATE DATABASE DB_ENTERTAINER

use DB_Entertainer

CREATE TABLE artis(
	Kd_artis Varchar(100),
	nm_artis varchar (100),
	jk varchar (100),
	bayaran money,
	award int,
	negara varchar(100)

	constraint PK_artis primary key (kd_artis)
)

insert into artis(Kd_artis, nm_artis, jk, bayaran, award, negara)
values
	('A001', 'ROBERT DOWNEY JR', 'PRIA', 1000000000, 2, 'AS'),
		('A002', 'ANGELINA JOLIE', 'WANITA', 700000000, 1, 'AS'),
		('A003', 'JACKIE CHAN', 'PRIA', 200000000, 7, 'HK'),
		('A004', 'JOE TASLIM', 'PRIA', 350000000, 1, 'ID'),
		('A005', 'CHELSEA ISLAN', 'WANITA', 300000000, 0, 'ID')

CREATE TABLE film(
	Kd_film Varchar(10),
	nm_film varchar (55),
	genre varchar (55),
	artis varchar(55),
	produser varchar(55),
	pendapatan money,
	nominasi int,

	constraint PK_film primary key (kd_film)
)


INSERT INTO film (Kd_film, nm_film, genre, artis, produser, pendapatan, nominasi)
VALUES
	('F001', 'IRON MAN', 'G001', 'A001', 'PD01', 2000000000, 3),
	('F002', 'IRON MAN 2', 'G001', 'A001', 'PD01', 1800000000, 2),
	('F003', 'IRON MAN 3', 'G001', 'A001', 'PD01', 1200000000, 0),
	('F004', 'AVENGER: CIVIL WAR', 'G001', 'A001', 'PD01', 2000000000, 1),
	('F005', 'SPIDERMAN HOME COMING', 'G001', 'A001', 'PD01', 1300000000, 0),
	('F006', 'THE RAID', 'G001', 'A004', 'PD03', 800000000, 5),
	('F007', 'FAST & FURIOUS', 'G001', 'A004', 'PD05', 830000000, 2),
	('F008', 'HABIBIE DAN AINUN', 'G004', 'A005', 'PD03', 670000000, 4),
	('F009', 'POLICE STORY', 'G001', 'A003', 'PD02', 700000000, 3),
	('F010', 'POLICE STORY 2', 'G001', 'A003', 'PD02', 710000000, 1),
	('F011', 'POLICE STORY 3', 'G001', 'A003', 'PD02', 615000000, 0),
	('F012', 'RUSH HOUR', 'G003', 'A003', 'PD05', 695000000, 2),
	('F013', 'KUNGFU PANDA', 'G003', 'A003', 'PD05', 923000000, 5)

CREATE TABLE produser(
	kd_produser Varchar(50),
	nm_produser varchar (50),
	international varchar (50),
	bayaran int,
	award int,
	negara varchar(100)

	constraint PK_produser primary key (kd_produser)
)

INSert into produser(kd_produser, nm_produser, international)
Values
	('PD01', 'MARVEL', 'YA'),
	('PD02', 'HONGKONG CINEMA', 'YA'),
	('PD03', 'RAPI FILM', 'TIDAK'),
	('PD04', 'PARKIT', 'TIDAK'),
	('PD05', 'PARAMOUNT PICTURE', 'YA')

CREATE TABLE negara(
	kd_negara varchar(100),
	nm_negara varchar(100),

	constraint pk_negara primary key (kd_negara)
)

INSERT INTO negara(kd_negara, nm_negara)
values
	('AS', 'AMERIKA SERIKAT'),
	('HK', 'HONGKONG'),
	('ID', 'INDONESIA'),
	('IN', 'INDIA')

CREATE TABLE genre(
	kd_genre varchar(50),
	nm_genre varchar(50),

	constraint pk_genre primary key (kd_genre)
)

INSERT INTO genre (kd_genre, nm_genre)
VALUES
	('G001','ACTION'),
	('G002','HORROR'),
	('G003','COMEDY'),
	('G004','DRAMA'),
	('G005','THRILLER'),
	('G006','FICTION')

--SOAL NO 1
select p.nm_produser, sum(f.pendapatan) as total_pendapatan
from film as f INNER JOIN produser as p
ON f.produser = p.kd_produser
where p.nm_produser = 'MARVEL'
group by p.nm_produser

--SOAL NO2 
SELECT nm_film, nominasi
FROM film
where nominasi = 0

--SOAL NO3
select nm_film from film
where nm_film like 'p%'

--soal NO4
select nm_film from film
where nm_film like '%y'

--SOAL NO5
select nm_film from film
where nm_film like '%d%'

--SOAL NO6
select f.nm_film, a.nm_artis
from film as f INNER JOIN artis as a
ON f.artis = a.Kd_artis

--SOAL NO7
select f.nm_film, a.negara
from film as f INNER JOIN artis as a
ON f.artis = a.Kd_artis
WHERE negara = 'HK'

--SOAL NO8
select f.nm_film, n.nm_negara
from film as f INNER JOIN artis as a
ON f.artis = a.Kd_artis
INNER JOIN negara as n
ON a.negara = n.kd_negara
WHERE NOT nm_negara LIke '%o%'

--SOAL NO9
select a.nm_artis from artis as a left join film as f
ON a.Kd_artis = f.artis
WHERE f.Kd_film is null

--SOAL NO10
select a.nm_artis, g.nm_genre from artis a INNER JOIN film f
ON a.Kd_artis = f.artis
INNER JOIN genre g
ON f.genre = g.kd_genre
WHERE g.nm_genre = 'DRAMA'

--SOAL 11
select distinct a.nm_artis, g.nm_genre from artis a INNER JOIN film f
ON a.Kd_artis = f.artis
INNER JOIN genre g
ON f.genre = g.kd_genre
WHERE g.nm_genre = 'ACTION'

--SOAL 12
select n.kd_negara, n.nm_negara, count(f.nm_film) jmlh_film
from artis a full 
outer join negara n ON a.negara = n.kd_negara
full outer join film f ON a.Kd_artis = f.artis
group by n.kd_negara, n.nm_negara

--SOAL 13
select f.nm_film 
from film f INNer JOIN produser p
ON f.produser = p.kd_produser
WHERE p.international = 'YA'

--SOAL 14
select p.nm_produser, count(f.nm_film) jmlh_film from produser p 
FULL OUTER JOIN film f
ON p.kd_produser = f.produser
group by  p.nm_produser



CREATE DATABASE DB_Sales

USE DB_Sales

CREATE TABLE SALESPERSON(
	ID int identity,
	NAMA varchar(50),
	BOD date,
	SALARY decimal(18,2)

	constraint pk_SALESPERSON PRIMARY KEY(ID)
)

INSERT INTO salesperson
values	('Abe',	'9/11/1988', 140000),
		('Bob',	'9/11/1978', 44000),
		('Chris','9/11/1983', 40000),
		('Dan',	'9/11/1980', 52000),
		('Ken',	'9/11/1977', 115000),
		('Joe',	'9/11/1990', 38000)

CREATE TABLE ORDERS(
	ID	int identity,
	ORDER_DATE date,
	CUST_ID int,
	SALESPERSON_ID int,
	AMOUNT decimal(18,2)

	constraint pk_ORDERS primary key(ID)
)

INSERT INTO orders
values	('8/2/2020',4,2	,540),
		('1/22/2021',4,5,1800),
		('7/14/2019',9,1,460),
		('1/29/2018',7,2,2400),
		('2/3/2021',6,4	,600),
		('3/2/2020',6,4	,720),
		('5/6/2021',9,4	,150)

select*from salesperson
select*from orders

--SOAL NO 1
select sp.NAMA, count(SALESPERSON_ID)
from salesperson as sp
inner join orders as o
ON sp.ID = o.SALESPERSON_ID
group by sp.nama
having count(SALESPERSON_ID)>1

--SOAL NO2 Informasi nama sales yang total amount ordernya di atas 1000.
select sp.NAMA, sum(o.AMOUNT)as total
from salesperson as sp
inner join orders as o
ON sp.ID = o.SALESPERSON_ID
group by sp.NAMA
having sum(o.AMOUNT)>1000

--soal NO 3 c. Informasi nama sales, umur, gaji dan total amount order yang 
--tahun ordernya >= 2020 dan data ditampilan berurut sesuai dengan umur (ascending).
select sp.NAMA,
		DATEDIFF(year, sp.BOD, GETDATE()) as umur,
		sp.SALARY,
		sum(o.AMOUNT) as total_order
from salesperson as sp
inner join orders as o
ON sp.ID = o.SALESPERSON_ID
group by sp.NAMA, sp.BOD, sp.Salary, o.ORDER_DATE
having year(o.ORDER_DATE) >= 2020
order by umur

-- d. Carilah rata-rata total amount masing-masig sales urutkan dari hasil yg paling besar								
select sp.NAMA,
		AVG(o.AMOUNT) as rata-rata
from salesperson as sp
inner join orders as o
ON sp.ID = o.SALESPERSON_ID
group by sp.NAMA
order by AVG(o.AMOUNT) desc

--e. perusahaan akan memberikan bonus bagi sales yang berhasil 
--memiliki order lebih dari 2 dan total order lebih dari 1000 sebanyak 30% dari salary									
select sp.NAMA, (sp.SALARY*0.3) as bonus
from salesperson as sp
inner join orders as o
ON sp.ID = o.SALESPERSON_ID
group by sp.NAMA, sp.SALARY
having count(o.SALESPERSON_ID) > 2 and sum(o.AMOUNT) > 1000

--f. Tampilkan data sales yang belum memiliki orderan sama sekali						
select sp.NAMA, o.order_date
from salesperson as sp
full join orders as o
ON sp.ID = o.SALESPERSON_ID
where o.ORDER_DATE is null

-- g. Gaji sales akan dipotong jika tidak memiliki orderan,  gaji akan di potong sebanyak 2%								
select sp.NAMA, sp.SALARY, sp.SALARY*.02 as potongan, sp.SALARY*(1-0.02) as penalty
from salesperson as sp
full join orders as o
ON sp.ID = o.SALESPERSON_ID
where o.AMOUNT is null













		
		
		
		
		
		


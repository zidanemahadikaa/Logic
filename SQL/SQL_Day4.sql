/* STORED PROCEDURE: kumpulan query yang membuat 1 fungsi tertentu
	
	CREATE PROCEDURE <usp_nama_procedur>
		[@parameter_1],.....,[@parameter_n] || [@parameter_1][=nilai_default],.....,[@parameter_n][= nilai_default]
	as
	[begin]
		--Query Statements...
	[END]
	GO
*/
use DB_Sales
go

create procedure usp_sales_min_total_order
	@min_total_order int
AS
	select s.nama, count(o.SALESPERSON_ID) total_order
	from SALESPERSON s inner join ORDERS o on s.ID=o.SALESPERSON_ID
	group by s.NAMA
	having COUNT(o.SALESPERSON_ID) >= @min_total_order
GO

usp_sales_min_total_order 1

create procedure usp_min_sales_total_amount
	@amount int
AS
	select sp.NAMA, sum(o.AMOUNT)as total
	from salesperson as sp
	inner join orders as o
	ON sp.ID = o.SALESPERSON_ID
	group by sp.NAMA
	having sum(o.AMOUNT)> @amount
go

usp_min_sales_total_amount 2000

use DB_Univ_XA
go

create procedure usp_jmlh_sks_mhs
	@min_sks int, @max_sks int
AS
Select ms.Nim, ms.nama, sum(mk.sks) as jmlh_sks
from Mahasiswa as ms 
INNER JOIN ambil_mk as a ON ms.Nim=a.nim
INNER join Matakuliah as mk ON a.kode_mk = mk.kode_mk
group by  ms.Nim, ms.nama
having sum(mk.sks) > @min_sks and sum(mk.sks)< @max_sks

usp_jmlh_sks_mhs 2, 10

usp_jmlh_sks_mhs @max_sks=10, @min_sks = 2

/* FUNCTION : kumpulan Query yang rangkaian proses/Query dan menghasilkan nilai keluaran()
	CREATE FUNCTION <fn_nama_function>
	([@parameter_1],....,[@parameter_n])
	RETURNS <DataType>
	AS
	BEGIN
		--statement Query
		RETURN <nilai_keluaran>
	END
*/
CREATE FUNCTION fn_penjumlahan (@angka1 int, @angka2 int)
	RETURNS int
	AS
	BEGIN
		declare @hasil int
		SET @hasil = (@angka1 + @angka2)

		RETURN @hasil;
	END

select dbo.fn_penjumlahan (1,2) hasil_penjumlahan

use DB_PTXA
go

CREATE FUNCTION fn_trending_cuti()
returns int
AS
BEGIN
	DECLARE @top_cuti int

	select  top 1 @top_cuti = COUNT(lr.reason)
	from leave_request lr inner join employee e on lr.employee_id=e.Id
	inner join leave l on lr.leave_id =l.id
	group by lr.reason
	order by COUNT(lr.reason) desc

	return @top_cuti
end

select dbo.fn_trending_cuti() banyak_cuti
go


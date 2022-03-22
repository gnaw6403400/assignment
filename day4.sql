
--Use Northwind database. All questions are based on assumptions described by the Database Diagram sent to you yesterday.
--When inserting, make up info if necessary. Write query for each step. Do not use IDE. BE CAREFUL WHEN DELETING DATA OR DROPPING TABLE.

--1.      Create a view named ¡°view_product_order_[your_last_name]¡±, list all products and total ordered quantity for that product.
create view view_product_order_wang as
select p.ProductID, p.ProductName, sum(od.Quantity)[Total Ordered Quantity]
from Products p
left join [Order Details] od on p.ProductID = od.ProductID
group by p.ProductID, p.ProductName
--select distinct ProductID, sum(Quantity) over (partition by ProductID order by productID) from [Order Details]

--2.      Create a stored procedure ¡°sp_product_order_quantity_[your_last_name]¡± that accept product id as an input and 
--total quantities of order as output parameter.

--drop proc sp_product_order_quantity_wang
create proc sp_product_order_quantity_wang
@id int, @quantity int out 
as begin
--select from view
--select @quantity = [Total Ordered Quantity] from view_product_order_wang where ProductID = @id

--select from original query
select  @quantity =  sum(od.Quantity)
from Products p
left join [Order Details] od on p.ProductID = od.ProductID
group by p.ProductID, p.ProductName
having p.ProductID = @id

end

--declare @result int
--exec sp_product_order_quantity_wang 1, @result out
--print @result


--3.      Create a stored procedure ¡°sp_product_order_city_[your_last_name]¡± that accept product name as an input and
--top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.

--drop proc sp_product_order_city_wang

create proc sp_product_order_city_wang
@prodName varchar(30) as
begin

select top 5 City, SUM(Quantity)[Quantity Ordered]
from Customers c 
join Orders o on o.CustomerID=c.CustomerID 
join [Order Details] od on od.OrderID=o.OrderID 
join Products p on p.ProductID = od.ProductID
group by  p.ProductName, city 
having  p.ProductName = @prodName
order by SUM(Quantity) desc

end

--exec sp_product_order_city_wang 'Mishi Kobe Niku'



--4.      Create 2 new tables ¡°people_your_last_name¡± ¡°city_your_last_name¡±. 
--City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
--People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}.
--Remove city of Seattle. If there was anyone from Seattle, put them into a new city ¡°Madison¡±. 
--Create a view ¡°Packers_your_name¡± lists all people from Green Bay. 
--If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.



create table people_wang(
Id int, Name varchar(20), City varchar(20))

create table city_wang(
Id int, city varchar(20))

insert into city_wang values(1, 'Seattle'), (2, 'Green Bay')
insert into people_wang values(1, 'Aaron Rodgers', 2), (2, 'Russell Wilson',1), (3, 'Jody Nelson', 2)

delete from city_wang where city = 'Seattle'

insert into city_wang values(3, 'Madison')

update people_wang set city = 3 where city = 1
go

create view Packers_Kaijing_Wang as
select Name, City
from people_wang
where City = 2




select * from city_wang
select * from people_wang
select * from Packers_Kaijing_Wang

drop table city_wang 
drop table people_wang
drop view Packers_Kaijing_Wang



--5.       Create a stored procedure ¡°sp_birthday_employees_[you_last_name]¡± that creates a new table
--¡°birthday_employees_your_last_name¡± and fill it with all employees that have a birthday on Feb.
--(Make a screen shot) drop the table. Employee table should not be affected.


create proc sp_birthday_employees_wang as
begin
select *
into birthday_employees_wang
from Employees
where month(BirthDate) = '2' 

end

exec sp_birthday_employees_wang
select * from birthday_employees_wang
drop table birthday_employees_wang

--6.      How do you make sure two tables have the same data?
--you can union them and see if the row count stay the same



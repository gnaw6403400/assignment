
--1.      List all cities that have both Employees and Customers.
select distinct c.City
from Customers c
left join Employees e on c.City = e.City
where c.City = e.City


--2.      List all cities that have Customers but no Employee.

--a.      Use sub-query

select distinct city 
from customers
where city not in (select distinct city [cities] from Employees)

--b.      Do not use sub-query
select distinct c.City
from Customers c 
left join Employees e on c.City = e.City
where e.City is null




--3.      List all products and their total order quantities throughout all orders.

--select p.ProductID, SUM(od.Quantity) [Num Of Sale]
--from Products p
--left join [Order Details] od on p.ProductID = od.ProductID
--left join Orders o on od.OrderID = o.OrderID
--group by p.ProductID

select ProductID, SUM(Quantity) [Num Of Sale] 
from [Order Details] 
group by ProductID
order by ProductID


--4.      List all Customer Cities and total products ordered by that city.
select c.City, count(1) [Total products sale]
from Customers c
left join Orders o on c.CustomerID = o.CustomerID
group by c.City


--5.      List all Customer Cities that have at least two customers.

--a.      Use union

--b.      Use sub-query and no union

--c.  use neither
select c.City, count(1)[num of customers]
from Customers c
group by c.City
having count(1) >= 2



--6.      List all Customer Cities that have ordered at least two different kinds of products.

select c.City, count(distinct od.ProductID) [product type]
from Customers c
left join Orders o on c.CustomerID = o.CustomerID
left join [Order Details] od on od.OrderID = o.OrderID
group by c.City
having count(distinct od.ProductID) >= 2
order by c.City



--7.      List all Customers who have ordered products, but have the ¡®ship city¡¯ on the order different from their own customer cities.
select c.ContactName, c.City, o.ShipCity
from Customers c
left join Orders o on c.CustomerID = o.CustomerID
where c.City <> o.ShipCity




--8.*      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

with tbl(ProductID, City, num, rank) as(
	select od.ProductID, c.City, count(1)[num of product], ROW_NUMBER() over (partition by od.ProductID order by count(1) desc) [rank]
	from [Order Details] od
	join Orders o on od.OrderID = o.OrderID
	join Customers c on o.CustomerID = c.CustomerID
	group by od.ProductID, c.City
) 
select  distinct top 5 od.ProductID, 
count(1) over (partition by od.ProductID) [quantity], 
avg(od.UnitPrice) over (partition by od.ProductID) [AvgPrice],
tbl.City [City ordered the most]
from Customers c
join Orders o on c.CustomerID = o.CustomerID
join [Order Details] od on od.OrderID = o.OrderID
join tbl on od.ProductID = tbl.ProductID and tbl.rank = 1
order by quantity desc




--9.      List all cities that have never ordered something but we have employees there.

--a.      Use sub-query
select distinct city 
from Employees
where city not in (select distinct city [cities] from Customers)


--b.      Do not use sub-query
select e.City
from Customers c 
right join Employees e on e.City = c.City
where c.City is null


--10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, 
--and also the city of most total quantity of products ordered from. (tip: join  sub-query)


select top 1 tbl.city, [Order Num], tbl1.City, [Quantity Sum]
from(
select distinct e.City, count(1)[Order Num]
from Employees e
join Orders o on e.EmployeeID = o.EmployeeID
group by e.City
) tbl

,(
select c.City, sum(od.Quantity)[Quantity Sum]
from Customers c
join Orders o on c.CustomerID = o.CustomerID
join [Order Details] od on od.OrderID = o.OrderID
group by c.City
) tbl1
order by [Order Num] desc, [Quantity Sum] desc

 


--11. How do you remove the duplicates record of a table?

--you can use distinct, rank(), ROW_NUMBER()


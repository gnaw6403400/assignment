use AdventureWorks2019
go

--1.      How many products can you find in the Production.Product table?
select count(p.ProductID)
from Production.Product p


--2.      Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.

select count(p.ProductID)
from Production.Product p
where p.ProductSubcategoryID is not NULL

--3.      How many Products reside in each SubCategory? Write a query to display the results with the following titles.

--ProductSubcategoryID CountedProducts

---------------------- ---------------
select p.ProductSubcategoryID, count(p.ProductSubcategoryID) [CountedProducts]
from Production.Product p
where p.ProductSubcategoryID is not NULL
group by p.ProductSubcategoryID

--4.      How many products that do not have a product subcategory.

select count(p.ProductID)
from Production.Product p
where p.ProductSubcategoryID is NULL


--5.      Write a query to list the sum of products quantity in the Production.ProductInventory table.
select sum(p.Quantity)
from Production.ProductInventory p




--6.    Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40
--and limit the result to include just summarized quantities less than 100.
--              ProductID    TheSum
--              -----------        ----------
select p.ProductID, sum(p.Quantity) [TheSum]
from Production.ProductInventory p
where p.LocationID = 40 
group by p.ProductID
having sum(p.Quantity) < 100




--7.    Write a query to list the sum of products with the shelf information in the Production.ProductInventory table
--and LocationID set to 40 and limit the result to include just summarized quantities less than 100

--    Shelf      ProductID    TheSum
--    ----------   -----------        -----------

select p.Shelf, p.ProductID, sum(p.Quantity) [TheSum]
from Production.ProductInventory p
where p.LocationID = 40 
group by p.ProductID,  p.Shelf
having sum(p.Quantity) < 100


--8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the
--table Production.ProductInventory table.

select avg(p.Quantity) [The Average]
from Production.ProductInventory p
where p.LocationID = 10 





--9.    Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory

--    ProductID   Shelf      TheAvg
--    ----------- ---------- -----------
select p.ProductID, p.Shelf, avg(p.Quantity) [The Average]
from Production.ProductInventory p
where p.LocationID = 10 
group by p.ProductID,  p.Shelf



--10.  Write query  to see the average quantity  of  products by shelf excluding rows that
--has the value of N/A in the column Shelf from the table Production.ProductInventory

--    ProductID   Shelf      TheAvg
--    ----------- ---------- -----------
select p.ProductID, p.Shelf, avg(p.Quantity) [The Average]
from Production.ProductInventory p
where p.LocationID = 10  AND p.Shelf <> 'N/A'
group by p.ProductID,  p.Shelf





--11.  List the members (rows) and average list price in the Production.Product table. 
--This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.

--    Color                        Class              TheCount          AvgPrice
--    -------------- - -----    -----------            ---------------------
--Joins:
select p.Color, p.Class, count(1) [TheCount], avg(p.ListPrice) [AvgPrice]
from Production.Product p
where p.Color is not null AND p.Class is not null
group by p.Color, p.Class



--12.   Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables.
--Join them and produce a result set similar to the following.

--    Country                        Province
--    ---------                          ----------------------

select cr.Name [Country], sp.Name [Province]
from Person.CountryRegion cr
join Person.StateProvince sp on cr.CountryRegionCode = sp.CountryRegionCode


--13.  Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables 
--and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

--    Country                        Province
--    ---------                          ----------------------

select cr.Name [Country], sp.Name [Province]
from Person.CountryRegion cr
join Person.StateProvince sp on cr.CountryRegionCode = sp.CountryRegionCode
where cr.Name in ('Germany', 'Canada')


-- Using Northwnd Database: (Use aliases for all the Joins)
use Northwind
go


--14.  List all Products that has been sold at least once in last 25 years.
select distinct p.ProductID
from Orders o 
join [Order Details] od on o.OrderID = od.OrderID
join Products p on p.ProductID = od.ProductID
where o.OrderDate > DATEADD(year, -25, GETDATE())


--15.  List top 5 locations (Zip Code) where the products sold most.

select top 5 o.ShipPostalCode, count(p.ProductID) [Product Num]
from Orders o 
join [Order Details] od on o.OrderID = od.OrderID
join Products p on p.ProductID = od.ProductID
where o.ShipPostalCode is not null
group by o.ShipPostalCode
order by count(p.ProductID) desc




--16.  List top 5 locations (Zip Code) where the products sold most in last 25 years.

select top 5 o.ShipPostalCode, count(p.ProductID) [Product Num]
from Orders o 
join [Order Details] od on o.OrderID = od.OrderID
join Products p on p.ProductID = od.ProductID
where o.ShipPostalCode is not null AND o.OrderDate > DATEADD(year, -25, GETDATE())
group by o.ShipPostalCode
order by count(p.ProductID) desc


--17.   List all city names and number of customers in that city.     

select o.ShipCity, count(distinct o.CustomerID) [Num of Customers]
from Orders o
group by o.ShipCity






--18.  List city names which have more than 2 customers, and number of customers in that city
select o.ShipCity, count(distinct o.CustomerID) [Num of Customers]
from Orders o
group by o.ShipCity
having count(distinct o.CustomerID) > 2



--19.  List the names of customers who placed orders after 1/1/98 with order date.
select distinct c.ContactName
from Customers c
join Orders o on c.CustomerID = o.CustomerID
where o.OrderDate > '1/1/98'



--20.  List the names of all customers with most recent order dates
select top 5 percent  c.ContactName, o.OrderDate
from Customers c
join Orders o on c.CustomerID = o.CustomerID
order by o.OrderDate desc



--21.  Display the names of all customers  along with the  count of products they bought

select c.ContactName, count(od.ProductID)
from Customers c
join Orders o on c.CustomerID = o.CustomerID
join [Order Details] od on o.OrderID = od.OrderID
group by c.ContactName



--22.  Display the customer ids who bought more than 100 Products with count of products.
select c.ContactName, count(od.ProductID)
from Customers c
join Orders o on c.CustomerID = o.CustomerID
join [Order Details] od on o.OrderID = od.OrderID
group by c.ContactName
having count(od.ProductID) > 100




--23.  List all of the possible ways that suppliers can ship their products. Display the results as below

--    Supplier Company Name                Shipping Company Name
--    ---------------------------------            ----------------------------------



select sp.CompanyName [Supplier Company Name], s.CompanyName [Shipping Company Name]
from Shippers s , Suppliers sp



--24.  Display the products order each day. Show Order date and Product Name.

--requirement not clear
select p.ProductName, o.OrderDate, count(p.ProductID) [Product bought]
from Products p
join [Order Details] od on od.ProductID = p.ProductID
join Orders o on o.OrderID = od.OrderID
group by p.ProductName, o.OrderDate
order by p.ProductName


--25.  Displays pairs of employees who have the same job title.


select e1.FirstName + ' ' + e1.LastName [Employee1], e2.FirstName + ' ' + e2.LastName [Employee2]
from Employees e1 cross join Employees e2 
where e1.Title = e2.Title AND e1.FirstName + ' ' + e1.LastName  <> e2.FirstName + ' ' + e2.LastName

--26.  Display all the Managers who have more than 2 employees reporting to them.

select m.FirstName + ' ' + m.LastName [Manager Name], count(1) [Employees under]
from Employees m  join Employees e on e.ReportsTo = m.EmployeeID
group by m.FirstName + ' ' + m.LastName 
having count(1)> 2



--27.  Display the customers and suppliers by city. The results should have the following columns

--City
--Name
--Contact Name,
--Type (Customer or Supplier)

select c.City, c.ContactName, 'Customer' [Type]
from Customers c 
union
select s.City, s.ContactName, 'Supplier'
from Suppliers s 



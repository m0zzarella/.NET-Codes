
create database Sales_Practice

use Sales_Practice

create table StockInfo (
    productid int primary key, 
    pName varchar(20), 
    pPrice int, 
    pAvailableqty int
)

insert into stockinfo values
    (1, 'Product 1', 100, 10),
    (2, 'Product 2', 200, 20),
    (3, 'Product 3', 300, 30),
    (4, 'Product 4', 400, 40),
    (5, 'Product 5', 500, 50)

 


create table salesinfo (
    saleid int primary key, 
    productid int foreign key references stockinfo(productid), 
    saleqty int
)

create table reorderinfo (
    rid int primary key, 
    pid int foreign key references stockinfo(productid), 
    availableqty int, 
    reorderqty int
)

insert into salesInfo values (1,2,8)

create trigger trg_afterSales
on SalesInfo
after Insert
as 
Begin
    declare @pid int
	declare @salesQty int
	set @pid = (select productId from inserted)
	set @salesQty = (select saleqty from inserted)
	update 
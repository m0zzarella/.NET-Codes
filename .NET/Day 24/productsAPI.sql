create database productsDB

use productsDB

create table productDetails
(pID int primary key,
pName varchar(20),
pPrice int,
pCategory varchar(20),
pAvailableQty int,
pIsInStock bit
)


insert into productDetails values (10, 'Maggi', 10, 'Snacks', 10, 1),
									(20, 'Milk', 40, 'Dairy', 50, 1),
									(30, 'Hersheys', 80, 'Chocolate', 100, 1),
									(40, 'Cadbury', 40, 'Chocolate', 90, 1),
									(50, 'Good Day', 10, 'Biscuits', 60, 1),
									(60, 'Parle', 10, 'Biscuits', 200, 1),
									(70, 'Butter', 50, 'Dairy', 5, 0);
									select * from productDetails

create table CustomerDetails
(cID int primary key,
cName varchar(20),
cCity varchar(20),
cWalletBalance int,
cIsActive bit
)
insert into CustomerDetails values (1, 'Roger', 'London',1000, 1),
(2, 'David', 'Manchester',2000, 1),
(3, 'Richard', 'Liverpool',1500, 0),
(4, 'Nick', 'New York',3000, 1),
(5, 'John', 'Paris',4000, 0);

select * from CustomerDetails

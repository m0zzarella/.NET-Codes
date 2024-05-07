create database ShoppingDB_API;
 
use ShoppingDB_API;
 
create table products (
    pID int primary key,
    pName varchar(255),
    pPrice decimal(10,2),
    pAvailableQty int,
    pIsInStock bit,
    pDiscountPercentage decimal(5,2),
    pOfferCode varchar(50),
    pOfferCodePercentage decimal(5,2)
);

insert into products values
(1, 'Nestle Maggi', 10, 150, 1, 0, NULL, 0),
(2, 'Heinz Ketchup', 75, 100, 1, 5, 'HEINZ5', 5),
(3, 'Coca Cola', 15, 200, 1, 10, 'COKE10', 10),
(4, 'Doritos Chips', 40, 120, 1, 0, NULL, 0),
(5, 'Tropicana Orange Juice', 49.9, 90, 1, 2.5, 'TROPIC', 2.5),
(6, 'Hershey Chocolate Bar', 35, 180, 1, 0, NULL, 0),
(7, 'Lays Potato Chips', 20, 130, 1, 15, 'LAYS15', 15),
(8, 'Uncle Ben Rice', 320, 60, 1, 0, NULL, 0),
(9, 'Quaker Oats', 540, 70, 1, 10, 'OATS10', 10),
(10, 'Oreo Cookies', 39.9, 160, 1, 0, NULL, 0);
 
create table customerdetails (
    cID int primary key,
    cName varchar(40),
    cCity varchar(40),
    cWalletBalance decimal(10,2),
    cEmail varchar(40)
);
 
insert into customerdetails values
(1, 'John Doe', 'New York', 1505.00, 'johndoe@email.com'),
(2, 'Jane Smith', 'Los Angeles', 2205.50, 'janesmith@email.com'),
(3, 'Bob Johnson', 'Chicago', 750.25, 'bobjohnson@email.com');
 
create table orderdetails (
    oID int primary key,
    oProductID int,
    cID int,
    orderTotal decimal(10,2),
    foreign key (oproductid) references products(pID),
    foreign key (cID) references customerdetails(cID)
);
 
insert into orderdetails values
(101, 1, 1, 1900.99),
(201, 3, 2, 595.97);
 
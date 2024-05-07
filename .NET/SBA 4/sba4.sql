create database ProductsDB_API;
use ProductsDB_API;
create table Products (
    pId int primary key,
    pName varchar(100),
    pPrice decimal(10, 2),
    pAvailableQty int,
    pDescription varchar(100),
    pIsInStock bit
);
create table Customers (
    cId int primary key,
    cName varchar(50),
    cAddress varchar(50),
    cWalletBalance decimal(10, 2)
);
create table Orders (
    oId int primary key,
    cId int,
    pId int,
    oStatus varchar(50) check (oStatus IN ('Delivered', 'In Progress', 'Cancelled', 'Failed')),
    FOREIGN KEY (cId) REFERENCES Customers(cId),
    FOREIGN KEY (pId) REFERENCES Products(pId)
);
insert into Products values
(1, 'Macbook Pro', 300.00, 80, '13inch Laptop', 1),
(2, 'iPhone 13 Pro', 700.00, 15, 'A15 Chip', 1),
(3, 'Sony WH-1000XM4', 950.00, 20, 'Wireless Headphones', 1),
(4, 'iPad Air', 1100.99, 10, '11inch Tablet', 1),
(5, 'Samsung Galaxy Watch', 750.99, 25, 'Smartwatch', 1),
(6, 'Canon EOS R5', 550.99, 5, 'Mirrorless Camera', 0);

insert into Customers values
(1, 'John Doe', '123 Oak St', 0.00),
(2, 'Jane Smith', '456 Elm St', 150000.00),
(3, 'Charlie Brown', '789 Maple St', 180000.00),
(4, 'Calvin Hobbes', '101 Pine St', 220000.00),
(5, 'Paul McCartney', '222 Cedar St', 160000.00),
(6, 'Ringo Starr', '333 Pine St', 190000.00);

insert into Orders (oId, cId, pId, oStatus) values
(1, 1, 2, 'Delivered'),
(2, 2, 1, 'In Progress'),
(3, 3, 3, 'In Progress'),
(4, 4, 5, 'Cancelled'),
(5, 5, 4, 'Failed'),
(6, 6, 6, 'Delivered');




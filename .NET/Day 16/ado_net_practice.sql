create database ADONET_Practice

use ADONET_Practice


create table CustomerInfo 
(
    accNo int primary key, 
    accName varchar(20) NOT NULL,
    accType varchar(20) NOT NULL, 
    accBalance bigint NOT NULL, 

)

select * from CustomerInfo

insert into CustomerInfo values (10, 'Prayas', 'Savings', 1000);
 

 create table LoginInfo
 ( userName varchar(20) primary key,
   userPassword varchar(20)

)

insert into LoginInfo values('hehe', 'hehe@123'), ('hoho', 'hoho@123'), 
('john', 'john@123'), ('jane', 'jane@123'), ('rohan', 'rohan@123'), ('prayas', 'prayas@123');

select * from LoginInfo

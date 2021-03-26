drop database salesdb;
--create database
create database salesdb;

--use database
use salesdb;

--create table

create table tproducts 
(
 prdid int primary key identity(1,1),
 prdname varchar(100),
 prddescription varchar(250),
 prdstock int,
 prdprice numeric(10,2),
 prdcategory varchar(50)
);

--create restrictions sintaxis 01
alter table tproducts
add check (prdstock>=1);

--create restrictions sintaxis 02
alter table tproducts
add constraint [Only you can add categories Office, Home or Street]
check (prdcategory in ('Office', 'Home', 'Street'));

--insert one row in table
insert into tproducts
(
prdname, prddescription, prdstock, prdprice, prdcategory
)
values
('TV 44pl Smart', 'LG new generation', 200, 1200.99, 'Home2');

--select products
select * from tproducts
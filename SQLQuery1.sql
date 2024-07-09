create database restro

create table items(
iid int identity(1,1) primary key,
name varchar(250) not null,
category varchar(250) not null,
price bigint not null
);

name,category,price

select *from items

truncate table items
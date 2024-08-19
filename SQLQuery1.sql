select * from UserTbl
select * from CategoryTbl
select * from ProductTbl
select * from CustomerTbl

truncate table Categorytbl

create table CustomerTbl 
(
CustId int primary key not null,
CustName varchar(50) not null,
CustPhone varchar(50) not null
)

create table CategoryTbl
(
CatId int not null primary key,
CatName varchar(50) not null
)

Create table ProductTbl
(
ProdId int not null primary key,
ProdName varchar(50) not null,
ProdQty int not null,
ProdPrice int not null,
ProdDesc varchar(10) not null,
ProdCat varchar(50) not null
)

update ProductTbl set ProdDesc varchar(100)
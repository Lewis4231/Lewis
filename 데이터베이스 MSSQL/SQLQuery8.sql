
drop table tblDetails
drop table tblMain



Select * from tblMain m inner join tblDetails d on m.MainID = d.MainID inner join products p on p.pID = d.proID Where m.MainID =  '5' 

select * from tblMain
select * from tblDetails



Create table tblMain
(
MainID int Primary key identity,
aDate date,
aTime Varchar(15),
TableName varchar(10),
WaiterName varchar(15),
status varchar(15),
orderType varchar(15),
total float,
received float,
change float,
driverID int,
CustName varchar(50),
CustPhone varchar(50)
)


Create table tblDetails
(
DetailID int Primary key identity,
MainID int,
proID int,
qty int,
price float,
amount float
)
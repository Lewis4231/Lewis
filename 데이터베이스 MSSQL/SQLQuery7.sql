

Select * from tblMain m
inner join tblDetails d on m.MainID = d.MainID
inner join products p on p.pID = d.proID
inner join category c on c.catID = p.CategoryID
where m.aDate between '2024-06-01' and '2024-07-31'fdsfdsfas
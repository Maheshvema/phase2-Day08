create database Day8Db_Assignment
use Day8Db_Assignment
create table Products
(PId nvarchar(50) primary key,
PName nvarchar(50) not null,
PPrice nvarchar(50) not null,
Mnfdate date not null,
ExpDate date not null
)

insert into Products values
('P0001','Laptop',75000,'12/12/2023','12/12/2028'),
('P0002','Pressure',65000,'12/12/2022','12/12/2027'),
('P0003','SlimFitBand',55000,'12/12/2021','12/12/2029'),
('P0004','Treadmill',45000,'12/12/2019','12/12/2028'),
('P0005','ZipLine',25000,'12/12/2019','12/12/2028'),
('P0006','XPro',15000,'12/12/2018','12/12/2028'),
('P0007','IPhone',85000,'12/12/2021','12/12/2028'),
('P0008','AC',25000,'12/12/2022','12/12/2028'),
('P0009','TV',35000,'12/12/2023','12/12/2028'),
('P00010','XIomi',75000,'12/12/2022','12/12/2028')

Select top 5 * from Products order by Pname desc


create table books(
ID int primary key identity(1,1),
Author varchar(100),
Title varchar(100),
Price int)

insert into books values('JK','Book1',90)
insert into books values('Tabu','Book2',8900)
insert into books values('Mira','Book3',9100)
insert into books values('Pga','Book3',9200)

select * from books
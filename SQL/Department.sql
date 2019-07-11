create table Department(
dept_number int primary key,
dept_name varchar(20) not Null,
dept_location varchar(30)
);

insert into Department values(10,'Sale','Mumbai')
insert into Department values(20,'Marketing','Pune')

select * from Department

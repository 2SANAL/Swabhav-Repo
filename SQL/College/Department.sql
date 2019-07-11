create table Depatment(
dept_id int primary key,
 dept_name varchar(20),
 location varchar(20)
)
ALTER TABLE Depatment DROP COLUMN location;

 insert into Depatment values('10','IT');
 insert into Depatment values('20','COMP');
  insert into Depatment values('30','Civil');
  select * from Depatment;

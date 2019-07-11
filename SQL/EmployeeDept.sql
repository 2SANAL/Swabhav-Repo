create table Employee(
eno int primary key,
ename varchar(20),
salary float,
dept_number int,
FOREIGN KEY (dept_number) REFERENCES Department(dept_number)
);
 
 insert into Employee values(101,'Akash',25000,10);
 insert into Employee values(102,'Dhruv',35000,20);
  insert into Employee values(103,'sanal',35000,10);
   insert into Employee values(104,'Brijesh',25000,20);
 select * from Employee;
  
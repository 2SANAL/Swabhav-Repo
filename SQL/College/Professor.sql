create table Professor(
prof_id int primary key,
college_id int,
dept_id int,
prof_name varchar(20),
location varchar(20)
Foreign Key (college_id) references College(college_id),
Foreign Key (dept_id) references Depatment(dept_id)

)



insert into Professor values (1001,1,10,'Akash Jaiswal','Mumbai');
insert into Professor values (1002,1,20,'Akash Jaiswal','Mumbai');
insert into Professor values (1003,1,10,'Dhruv Ballikar','Pune');
select * from Professor;

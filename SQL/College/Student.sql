create table Student(
stud_id int primary key,
college_id int,
dept_id int,
stud_name varchar(20),
stud_location varchar(20),
stud_DOB date,
Foreign Key (college_id) references College(college_id),
Foreign Key (dept_id) references Depatment(dept_id)
)

insert into Student values('10001',1,10,'sanal dhamanse','Raigad',CONVERT(date,'22.12.2016',104));
insert into Student values('10002',1,20,'sanal dhamanse','Raigad',CONVERT(date,'22.12.2016',104));

select * from Student;
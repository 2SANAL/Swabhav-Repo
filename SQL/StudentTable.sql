
insert into  Student values(102,'Akash','Jasiwal',8.2);
insert into  Student values(103,'Dhruv','Ballikar',8.2);
insert into  Student values(104,'Dipesh','mane',8.2);
insert into  Student values(105,'Manish	','Jaiswal',8.2);
insert into  Student values(106,'Tejal','Jadhav',8.2);
insert into  Student values(107,'Akhilesh','Sing',8.2);
insert into  Student values(108,'Brijesh','Jaiswal',8.2);
insert into  Student values(109,'Mithlesh','Dhamanse',8.2);
insert into  Student values(110,'sam','Dhamanse',8.2);

select * from Student

update Student set student_cgpi= 7.9 where student_id=103;
update Student set student_cgpi= 6.8 where student_id=104;
update Student set student_cgpi= 8.8 where student_id=105;
update Student set student_cgpi= 9.9 where student_id=106;

delete from student where student_id=109; 


Alter table student ADD DOB date;
alter table student Drop column DOB;

ALTER TABLE Student 
ADD CONSTRAINT student_cgpi CHECK (student_cgpi>2.50);

insert into Student values(109,'sam','Dhamanse',2.6);


ALTER TABLE Student Alter column student_firstname varchar(30);
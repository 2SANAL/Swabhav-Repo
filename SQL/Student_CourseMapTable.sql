create table StudentCouserMapTable(
stude_id int,
course_id int,
Foreign Key (stude_id) references Student1(stud_id),
Foreign Key (course_id) references Course(course_id)
)

insert into StudentCouserMapTable values(101,1);
insert into StudentCouserMapTable values(101,2)
insert into StudentCouserMapTable values(101,3)

select * from StudentCouserMapTable;
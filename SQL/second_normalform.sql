create table TEACHER_DETAIL(TEACHER_ID int primary key,
                            TEACHER_AGE Decimal);
insert into TEACHER_DETAIL values(25,34)
insert into TEACHER_DETAIL values(47,32)
insert into TEACHER_DETAIL values(83,34)

select * from TEACHER_DETAIL

create table TEACHER_SUBJECT(TEACHER_ID int,
                             SUBJECT_NAME varchar(500),
							 constraint T1
							 foreign key(TEACHER_ID)
							 REFERENCES TEACHER_DETAIL
							 (TEACHER_ID));
insert into TEACHER_SUBJECT values(25,'chemistry')
insert into TEACHER_SUBJECT values(25,'biology')
insert into TEACHER_SUBJECT values(47,'english')
insert into TEACHER_SUBJECT values(83,'maths')

select * from TEACHER_DETAIL

select * from TEACHER_SUBJECT




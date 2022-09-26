
create database bank12

create table users (
id int identity (1,1)primary key,
userRole varchar(50) not null,
name varchar(50) not null,
username varchar(50) not null,
pass varchar (50)not null
)


select * from users

insert into users(userRole,name,username,pass) values('MA','sakila','sakila99','1234');

insert into users(userRole,name,username,pass) values('CA','nishu','nishu99','1234');

create table AccPass(
Acc_ID int identity(1,1)primary key,
fname varchar(50) not null,
lname varchar(50) not null,
Nic varchar(10) not null,
Dob Date not null,
gender varchar(10)not null,
salary float );


select * from AccPass

insert into AccPass (fname,lname,Nic,Dob,gender,salary) values ('sakila','sandanuwan','992113596v','1999/7/29','Male',25000);
insert into AccPass(fname,lname,Nic,Dob,gender,salary) values('QQQ','sWW','995465856v','1999/3/11','Female',50000) ;

insert into AccPass(fname,lname,Nic,Dob,gender,salary) values(@fname,@lname,@Nic,@Dob,@gender,@salary) ;

select Acc_ID,fname,lname,Nic,Dob,gender,salary from AccPass

select Acc_ID,fname,lname,Nic,Dob,gender,salary from AccPass where Acc_ID=1;

UPDATE AccPass SET fname='wasana' ,lname = 'sewwandi',Nic='987032189v' where Acc_ID=3
UPDATE AccPass SET fname='CA',lname='yy',Nic='1212' where Acc_ID =3

UPDATE AccPass SET fname=@fname,lname=@lname,Nic=@Nic where Acc_ID =@OldID;

delete from AccPass where Acc_ID=4;

UPDATE AccPass SET salary=56000 where Acc_ID=1;
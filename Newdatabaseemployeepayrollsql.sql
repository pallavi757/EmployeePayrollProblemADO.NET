create database EmployeePayroll;
use EmployeePayroll;

create table Employee(
EmpID int identity(1,1) primary key,
Name varchar(50),
PhoneNumber bigint,
Address varchar(200),
StartDate Date,
Gender char(1),
);

select * from Employee;

insert into Employee(Name,PhoneNumber,Address,StartDate,Gender) values
('Yogiraj','8811223338','Pune','2022-02-04','M'),
('Pallavi','9900221308','Mumbai','2022-03-14','F'),
('Atish','8001220038','Pune','2022-02-24','M');

select * from Employee;

create table Payroll
(ID int identity(1,1) primary key,
BasicPay bigint,
Deduction int,
TaxablePay int,
IncomeTax int,
NetPay int
foreign key(ID) references Employee(EmpID)
);

insert into Payroll(BasicPay,Deduction,TaxablePay,IncomeTax,NetPay)Values
(30000,2000,1000,200,26800),
(20000,2000,1000,200,18800),
(30000,2000,1000,200,26800);

select * from Payroll;

create table DepartmentTable
(
   ID int,
   Department varchar(20)
   foreign key(ID) references Employee(EmpID)
);

select * from DepartmentTable;

insert into DepartmentTable values
(1,'Sales'),
(2,'Marketing'),
(3,'Sales');

select Employee.EmpID, Name,StartDate,Gender,PhoneNumber,Address,Department,BasicPay,Deduction,TaxablePay,IncomeTax,NetPay from Employee 
left join DepartmentTable on Employee.EmpID = DepartmentTable.ID left join Payroll on Employee.EmpID = Payroll.ID;
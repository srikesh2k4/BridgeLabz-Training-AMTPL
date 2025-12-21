select * from sys.databases;
USE accounts;go
create table bills (
                       Id int primary key ,
                       BillNumber nvarchar ,
                       BillDate DATETIME,
                       TotalAmount dec ,
                       PaymentMode nvarchar,
                       CreatedBy varchar,
                       CreatedAt DATETIME
);

create database accounts;

use accounts;go

create schema billDetails
    authorization dbo;

create table billDetails.bills (
                                   Id int primary key ,
                                   BillNumber varchar ,
                                   BillDate datetime,
                                   TotalAmount decimal,
                                   PaymentMode varchar,
                                   CreatedBy varchar,
                                   CreatedAt DateTime,
);

create table billDetails.Products(
                                     Id int primary key ,
                                     ProductCode varchar ,
                                     ProductName varchar,
                                     Price decimal,
                                     Category varchar,
                                     IsActive binary,
);

create table billDetails.BillItems (
                                       Id int primary key ,
                                       BillId int ,
                                       ProductId int,
                                       Quantity int check(Quantity >=0 ),
                                       UnitPrice dec check(UnitPrice >=0),
                                       LineTotal dec,
                                       foreign key (BillId) references billDetails.bills(Id),
                                       foreign key (ProductId) references billDetails.Products(Id),
);

create table billDetails.Inventory(
                                      ProductId int primary key ,
                                      Stock int ,
                                      ReorderLevel int,
                                      LastUpdated DateTime,
                                      foreign key (ProductId) references billDetails.Products(Id)
);
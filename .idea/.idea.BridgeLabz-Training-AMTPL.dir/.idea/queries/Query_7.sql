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

UPDATE billDetails.Bills
SET CreatedAt = GETDATE()
WHERE CreatedAt IS NULL;

ALTER TABLE billDetails.Bills
    ALTER COLUMN BillNumber VARCHAR(50) NOT NULL;

ALTER TABLE billDetails.Bills
    ALTER COLUMN BillDate DATETIME NOT NULL;

ALTER TABLE billDetails.Bills
    ALTER COLUMN TotalAmount DECIMAL(18,2) NOT NULL;

ALTER TABLE billDetails.Bills
    ALTER COLUMN PaymentMode VARCHAR(20) NOT NULL;

ALTER TABLE billDetails.Bills
    ALTER COLUMN CreatedAt DATETIME NOT NULL;


ALTER TABLE billDetails.Bills
    ADD CONSTRAINT UQ_Bills_BillNumber UNIQUE (BillNumber);

ALTER TABLE billDetails.Bills
    ADD CONSTRAINT CK_Bills_TotalAmount CHECK (TotalAmount >= 0);

ALTER TABLE billDetails.Bills
    ADD CONSTRAINT DF_Bills_CreatedAt DEFAULT GETDATE() FOR CreatedAt;


ALTER TABLE billDetails.Products
    ALTER COLUMN IsActive BIT NOT NULL;
ALTER TABLE billDetails.Products
    ALTER COLUMN ProductCode VARCHAR(30) NOT NULL;

ALTER TABLE billDetails.Products
    ALTER COLUMN ProductName VARCHAR(100) NOT NULL;

ALTER TABLE billDetails.Products
    ALTER COLUMN Price DECIMAL(18,2) NOT NULL;
ALTER TABLE billDetails.Products
    ADD CONSTRAINT UQ_Products_ProductCode UNIQUE (ProductCode);

ALTER TABLE billDetails.Products
    ADD CONSTRAINT CK_Products_Price CHECK (Price >= 0);



ALTER TABLE billDetails.Inventory
    ALTER COLUMN Stock INT NOT NULL;

ALTER TABLE billDetails.Inventory
    ALTER COLUMN ReorderLevel INT NOT NULL;

ALTER TABLE billDetails.Inventory
    ALTER COLUMN LastUpdated DATETIME NOT NULL;
ALTER TABLE billDetails.Inventory
    ADD CONSTRAINT CK_Inventory_Stock CHECK (Stock >= 0);

ALTER TABLE billDetails.Inventory
    ADD CONSTRAINT CK_Inventory_Reorder CHECK (ReorderLevel >= 0);

ALTER TABLE billDetails.Inventory
    ADD CONSTRAINT DF_Inventory_LastUpdated DEFAULT GETDATE() FOR LastUpdated;


ALTER TABLE billDetails.BillItems
    ALTER COLUMN UnitPrice DECIMAL(18,2) NOT NULL;

ALTER TABLE billDetails.BillItems
    ALTER COLUMN LineTotal DECIMAL(18,2) NOT NULL;
ALTER TABLE billDetails.BillItems
    ALTER COLUMN BillId INT NOT NULL;

ALTER TABLE billDetails.BillItems
    ALTER COLUMN ProductId INT NOT NULL;

ALTER TABLE billDetails.BillItems
    ALTER COLUMN Quantity INT NOT NULL;
ALTER TABLE billDetails.BillItems
    ADD CONSTRAINT CK_BillItems_Quantity CHECK (Quantity > 0);

ALTER TABLE billDetails.BillItems
    ADD CONSTRAINT CK_BillItems_LineTotal CHECK (LineTotal >= 0);

ALTER TABLE billDetails.BillItems
    ADD CONSTRAINT UQ_BillItems_Bill_Product UNIQUE (BillId, ProductId);

DROP TABLE IF EXISTS billDetails.BillItems;
DROP TABLE IF EXISTS billDetails.Inventory;
DROP TABLE IF EXISTS billDetails.Bills;
DROP TABLE IF EXISTS billDetails.Products;

DROP SCHEMA IF EXISTS billDetails;

CREATE SCHEMA billDetails AUTHORIZATION dbo;

CREATE TABLE billDetails.Bills (
                                   Id INT IDENTITY(1,1) PRIMARY KEY,
                                   BillNumber VARCHAR(50) NOT NULL UNIQUE,
                                   BillDate DATETIME NOT NULL,
                                   TotalAmount DECIMAL(18,2) NOT NULL CHECK (TotalAmount >= 0),
                                   PaymentMode VARCHAR(20) NOT NULL,
                                   CreatedBy VARCHAR(50),
                                   CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE billDetails.Products (
                                      Id INT IDENTITY(1,1) PRIMARY KEY,
                                      ProductCode VARCHAR(30) NOT NULL UNIQUE,
                                      ProductName VARCHAR(100) NOT NULL,
                                      Price DECIMAL(18,2) NOT NULL CHECK (Price >= 0),
                                      Category VARCHAR(50),
                                      IsActive BIT NOT NULL DEFAULT 1
);

CREATE TABLE billDetails.Inventory (
                                       ProductId INT PRIMARY KEY,
                                       Stock INT NOT NULL CHECK (Stock >= 0),
                                       ReorderLevel INT NOT NULL CHECK (ReorderLevel >= 0),
                                       LastUpdated DATETIME NOT NULL DEFAULT GETDATE(),
                                       CONSTRAINT FK_Inventory_Product
                                           FOREIGN KEY (ProductId)
                                               REFERENCES billDetails.Products(Id)
);

CREATE TABLE billDetails.BillItems (
                                       Id INT IDENTITY(1,1) PRIMARY KEY,
                                       BillId INT NOT NULL,
                                       ProductId INT NOT NULL,
                                       Quantity INT NOT NULL CHECK (Quantity > 0),
                                       UnitPrice DECIMAL(18,2) NOT NULL CHECK (UnitPrice >= 0),
                                       LineTotal DECIMAL(18,2) NOT NULL CHECK (LineTotal >= 0),
                                       CONSTRAINT FK_BillItems_Bill
                                           FOREIGN KEY (BillId)
                                               REFERENCES billDetails.Bills(Id),
                                       CONSTRAINT FK_BillItems_Product
                                           FOREIGN KEY (ProductId)
                                               REFERENCES billDetails.Products(Id),
                                       CONSTRAINT UQ_BillItems_Bill_Product
                                           UNIQUE (BillId, ProductId)
);



CREATE TABLE billDetails.Inventory (
                                       ProductId INT PRIMARY KEY,
                                       Stock INT NOT NULL CHECK (Stock >= 0),
                                       ReorderLevel INT NOT NULL CHECK (ReorderLevel >= 0),
                                       LastUpdated DATETIME NOT NULL DEFAULT GETDATE(),
                                       CONSTRAINT FK_Inventory_Product
                                           FOREIGN KEY (ProductId)
                                               REFERENCES billDetails.Products(Id)
);
CREATE TABLE billDetails.Inventory (
                                       ProductId INT PRIMARY KEY,
                                       Stock INT NOT NULL CHECK (Stock >= 0),
                                       ReorderLevel INT NOT NULL CHECK (ReorderLevel >= 0),
                                       LastUpdated DATETIME NOT NULL DEFAULT GETDATE(),
                                       CONSTRAINT FK_Inventory_Product
                                           FOREIGN KEY (ProductId)
                                               REFERENCES billDetails.Products(Id)
);

select * from accounts.billDetails.bills;


update billDetails.Bills 
set TotalAmount = TotalAmount - 2 
where Id = 4;
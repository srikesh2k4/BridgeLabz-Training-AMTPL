CREATE TABLE Bills (
bill_id INT IDENTITY(1,1) PRIMARY KEY,
customer_name VARCHAR(100) NOT NULL,
bill_price DECIMAL(10,2) NOT NULL,
bill_created_by VARCHAR(50) NOT NULL
);

CREATE TABLE BillItems (
item_id INT IDENTITY(1,1) PRIMARY KEY,
bill_id INT NOT NULL,
product_name VARCHAR(100) NOT NULL,
product_type VARCHAR(50) NOT NULL,
CONSTRAINT FK_BillItems_Bills
FOREIGN KEY (bill_id) REFERENCES Bills(bill_id)
);
       
CREATE TABLE Inventory (
inventory_id INT IDENTITY(1,1) PRIMARY KEY,
item_id INT NOT NULL,
product_quantity INT NOT NULL CHECK (product_quantity > 0),
product_added_by VARCHAR(50) NOT NULL,
CONSTRAINT FK_Inventory_BillItems
FOREIGN KEY (item_id) REFERENCES BillItems(item_id)
);


INSERT INTO Bills (customer_name, bill_price, bill_created_by)
VALUES ('Srikesh', 120.00, 'Admin');
INSERT INTO BillItems (bill_id, product_name, product_type)
VALUES (2, 'Jug', 'Water Can');
INSERT INTO Inventory (item_id, product_quantity, product_added_by)
VALUES (3, 10, 'Admin');

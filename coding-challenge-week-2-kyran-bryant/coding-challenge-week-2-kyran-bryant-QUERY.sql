--1)

CREATE TABLE Products (
    ProductID int IDENTITY(1,1) NOT NULL,
    Title varchar(50) NOT NULL,
    Price money,
   Primary Key(ProductID)
);

CREATE TABLE orders (
    OrderID INT IDENTITY(1,1) NOT NULL,
    ProductID INT NOT NULL,
    CustomerID INT NOT NULL,
   PRIMARY KEY(OrderID)
);

CREATE TABLE Customer (
	CustomerID  int IDENTITY(1,1) NOT NULL,
    FirstName varchar(50) NOT NULL,
    LastName varchar(50) NOT NULL,
    CardNumber int,
	PRIMARY KEY (CustomerID)
);


--2) 

INSERT INTO dbo.Products(Title, Price)
VALUES ('iphone', '200');


--3)
INSERT INTO dbo.Customer(FirstName, LastName)
VALUES ('Tina', 'Smith');


--4)
INSERT INTO dbo.Orders(CustomerID, ProductID)
VALUES(1,1)

--5)
SELECT * FROM dbo.Orders
INNER JOIN dbo.Customer ON Orders.CustomerID=Customer.CustomerID;

--6)
SELECT SUM(Price)
FROM dbo.Products;

--7)
UPDATE dbo.Products
SET Price = '250'
WHERE Title = 'iPhone';


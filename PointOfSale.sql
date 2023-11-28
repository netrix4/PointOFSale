
--DROP TABLE Product;
--DROP TABLE Transactions;
--DROP TABLE TransactionDetails;
--DROP DATABASE DBTest;

CREATE DATABASE DBTest

USE DBTest;

CREATE TABLE Product(
	ProductID  INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Name] VARCHAR(25) NOT NULL, 
	[Description] VARCHAR(25) NOT NULL,
	SKU VARCHAR(25) NOT NULL, 
	Price DECIMAL NOT NULL ,
)

INSERT INTO Product([Name], [Description], SKU, Price) VALUES('Pochomil2k', 'Super pochomil', 'PRD-777', 99.99);
INSERT INTO Product([Name], [Description], SKU, Price) VALUES('Pochomil', 'regular', 'PRD-777', 98.99);
INSERT INTO Product([Name], [Description], SKU, Price) VALUES('Platano', 'Chiapas', 'PRD-666', 19.99);
INSERT INTO Product([Name], [Description], SKU, Price) VALUES('Fresas', 'frescas', 'PRD-123', 21.99);
INSERT INTO Product([Name], [Description], SKU, Price) VALUES('Cebolla', 'Blanca', 'PRD-111', 11.50);
INSERT INTO Product([Name], [Description], SKU, Price) VALUES('Cebolla', 'Morada', 'PRD-222', 13.45);
INSERT INTO Product([Name], [Description], SKU, Price) VALUES('Leche', 'LaLa', 'PRD-333', 27.30);


SELECT * FROM Product;


SELECT * FROM[DBTest].[dbo].[Product] WHERE Description LIKE '%'Morada'%';

SELECT * FROM[DBTest].[dbo].[Product] WHERE [Name] LIKE  '' OR [SKU] LIKE '' OR [Description] LIKE '';


CREATE TABLE Transactions(
	--TransactionID INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	TransactionID INTEGER NOT NULL,
	--ProductID INTEGER NOT NULL FOREIGN KEY REFERENCES Product(ProductID),
	TransactionDate DATE NOT NULL,
	Total DECIMAL NOT NULL
)

INSERT INTO Transactions(ProductID, TransactionDate, Total) VALUES(3, GETDATE(), 2099.99)

SELECT * FROM Transactions;

CREATE TABLE TransactionDetails(
	TransactionDetailsID INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	--TransactionID INTEGER NOT NULL FOREIGN KEY REFERENCES Transactions(TransactionID),
	TransactionID INTEGER NOT NULL,
	ProductID INTEGER NOT NULL FOREIGN KEY REFERENCES Product(ProductID),
	CreationDate DATE NOT NULL
)

INSERT INTO TransactionDetails(TransactionID, ProductID, [CreationDate]) VALUES(1, 1, GETDATE());

SELECT * FROM TransactionDetails;
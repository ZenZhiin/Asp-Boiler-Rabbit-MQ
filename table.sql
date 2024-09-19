CREATE TABLE Product (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL,
    Price DECIMAL(18,2) NOT NULL
);

CREATE TABLE ProductStock (
    ProductId INT PRIMARY KEY,
    Quantity INT NOT NULL,
    FOREIGN KEY (ProductId) REFERENCES Product(Id)
);

CREATE TABLE [Order] (
    Id INT PRIMARY KEY IDENTITY(1,1),
    OrderNumber NVARCHAR(20) NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (ProductId) REFERENCES Product(Id)
);

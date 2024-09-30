create database Myntra

--create Table Users
--(
--Id int primary key identity(1,1),
--fullname Nvarchar(50) NOT NULL Unique,
--Email Nvarchar(50) NOT NULL Unique,
--Password Nvarchar(50) NOT NULL,
--ConfirmPassword Nvarchar(50) NOT NULL,
--Role Nvarchar(50) NOT NULL
--)


--select *from Users
use Myntra

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
	Fullname Nvarchar(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
	
    Role NVARCHAR(50) NOT NULL
);
 select *from Users

  CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY,        -- Unique identifier for each product
    ProductName NVARCHAR(100),                 -- Name of the product
    ProductPrice DECIMAL(18, 2),               -- Price of the product
    ProductDescription NVARCHAR(500),          -- Description of the product
    ProductImage NVARCHAR(300),                -- Image URL or path for the product
    Category NVARCHAR(100),                    -- Product category (e.g., Clothing, Footwear)
    Status NVARCHAR(50),                       -- Availability status (e.g., In Stock, Out of Stock)
    Color NVARCHAR(50),                        -- Color of the product
    Brand NVARCHAR(100)                        -- Brand of the product
);
 
-- To view all the records in the Products table:
SELECT * FROM Products;

 


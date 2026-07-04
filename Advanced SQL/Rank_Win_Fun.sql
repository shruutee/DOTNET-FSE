-- ==========================================================
-- Exercise 1 : Ranking and Window Functions
-- Goal:
-- Use ROW_NUMBER(), RANK(), DENSE_RANK(),
-- OVER(), and PARTITION BY
-- ==========================================================

-- Create Database
CREATE DATABASE IF NOT EXISTS AdvancedSQL;

-- Use Database
USE AdvancedSQL;

-- Create Products Table
CREATE TABLE IF NOT EXISTS Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Clear Existing Data
DELETE FROM Products;

-- Insert Sample Data
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1,'Laptop','Electronics',70000),
(2,'Mobile','Electronics',50000),
(3,'Headphones','Electronics',5000),
(4,'Smart Watch','Electronics',5000),
(5,'TV','Electronics',60000),
(6,'Sofa','Furniture',25000),
(7,'Dining Table','Furniture',35000),
(8,'Chair','Furniture',5000),
(9,'Bed','Furniture',35000),
(10,'Cupboard','Furniture',20000),
(11,'Shirt','Clothing',2000),
(12,'Jeans','Clothing',3000),
(13,'Jacket','Clothing',5000),
(14,'T-Shirt','Clothing',2000),
(15,'Blazer','Clothing',8000);

-- ==========================================================
-- 1. ROW_NUMBER()
-- Assigns a unique rank within each category
-- ==========================================================

SELECT *
FROM (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNum
    FROM Products
) AS Ranked
WHERE RowNum <= 3;

-- ==========================================================
-- 2. RANK()
-- Same rank for equal values and skips the next rank
-- ==========================================================

SELECT *
FROM (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RankNum
    FROM Products
) AS Ranked
WHERE RankNum <= 3;

-- ==========================================================
-- 3. DENSE_RANK()
-- Same rank for equal values without skipping the next rank
-- ==========================================================

SELECT *
FROM (
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS DenseRankNum
    FROM Products
) AS Ranked
WHERE DenseRankNum <= 3;
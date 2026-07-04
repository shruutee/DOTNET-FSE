-- Exercise 5

CREATE DATABASE IF NOT EXISTS AdvancedSQL;
USE AdvancedSQL;

CREATE TABLE IF NOT EXISTS Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);

DELETE FROM Employees;

INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('Harsh','Janghel',101,50000,'2024-01-15'),
('Rahul','Sharma',101,45000,'2024-02-10'),
('Priya','Patel',102,60000,'2023-12-05'),
('Amit','Verma',103,55000,'2022-11-20'),
('Sneha','Singh',102,65000,'2024-03-18'),
('Rohan','Mehta',103,70000,'2025-01-10');

DROP PROCEDURE IF EXISTS sp_TotalEmployeesByDepartment;

DELIMITER //

CREATE PROCEDURE sp_TotalEmployeesByDepartment(
    IN p_DepartmentID INT
)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END //

DELIMITER ;

CALL sp_TotalEmployeesByDepartment(101);

CALL sp_TotalEmployeesByDepartment(102);

CALL sp_TotalEmployeesByDepartment(103);
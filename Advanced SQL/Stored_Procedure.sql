-- Exercise 2

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
('Sneha','Singh',102,65000,'2024-03-18');

DROP PROCEDURE IF EXISTS sp_GetEmployeesByDepartment;

DELIMITER //

CREATE PROCEDURE sp_GetEmployeesByDepartment(IN p_DepartmentID INT)
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = p_DepartmentID;
END //

DELIMITER ;

CALL sp_GetEmployeesByDepartment(101);

DROP PROCEDURE IF EXISTS sp_InsertEmployee;

DELIMITER //

CREATE PROCEDURE sp_InsertEmployee(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)
BEGIN
    INSERT INTO Employees
    (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES
    (p_FirstName, p_LastName, p_DepartmentID, p_Salary, p_JoinDate);
END //

DELIMITER ;

CALL sp_InsertEmployee(
    'Rohan',
    'Mehta',
    103,
    70000,
    '2025-01-10'
);

SELECT * FROM Employees;

CALL sp_GetEmployeesByDepartment(101);
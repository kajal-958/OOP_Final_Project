CREATE DATABASE FinanicalTracker;
GO

USE FinanicalTracker;
GO

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    UserName VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL
);


INSERT INTO Users (UserName, Password, Email)
VALUES 
('Jerry', 'password123', 'jerry@example.com'),
('Tom', 'password456', 'tom@example.com');

SELECT * FROM Users

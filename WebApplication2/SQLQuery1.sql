CREATE DATABASE StudentDb
GO
CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Firstname NVARCHAR(50) NOT NULL,
Lastname NVARCHAR(50) NOT NULL,
Email NVARCHAR(50) NOT NULL
)
GO 
INSERT INTO Students([Firstname],[Lastname],[Email])
VALUES('Leyla','Eliyeva','l@gmail.com'),
('Aysel','Eliyeva','l@gmail.com')
SELECT * FROM Students
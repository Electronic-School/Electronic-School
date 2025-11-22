create DATABASE SchoolManagementDB;
GO

use SchoolManagementDB;
go


CREATE TABLE Parents(
	ParentsID INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	Address NVARCHAR(200),
	PhoneNumber NVARCHAR(15),
	Email NVARCHAR(100),
	ChildrenInSchool INT
);

CREATE TABLE Students(
	StudentsId INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	Grade INT;
	ParentID INT NOT NULL,
	CONSTRAINT FK_Student_Parent FOREIGN KEY (ParentID)
	REFERENCES Parents(ID)
);
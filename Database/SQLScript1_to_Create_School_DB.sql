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
);-- we need to alter this table with address ( adding addres as a forgin key) 
GO

CREATE TABLE Students(
	StudentsId INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	Address NVARCHAR(200),-- LINK TO WITH LOCATIONS TABLE SO WE WILL ALTER THIS TABLE 
	NUMBERO
	ParentID INT NOT NULL,
	CONSTRAINT FK_Student_Parent FOREIGN KEY (ParentID)
	REFERENCES Parents(ParentsID)
);

CREATE TABLE Locations(
	LocationID INT PRIMARY KEY IDENTITY(9,4),
	Country VARCHAR(50) NOT NULL,
	City VARCHAR(50) NOT NULL,
	Street VARCHAR(50) NOT NULL, 
	BuildingNo VARCHAR(30) NOT NULL
);

CREATE TABLE Courses (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    StartDate DATE,
    EndDate DATE,
    TeacherID INT NULL
);




CREATE TABLE Teachers (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE,

    Salary DECIMAL(10, 2),
    EducationDegree NVARCHAR(100),
    TeachingSubject NVARCHAR(100),
    StartWorkingDate DATE,
    NumberOfVacations INT,
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    SocialStatus NVARCHAR(50)
);

ALTER TABLE Courses
ADD CONSTRAINT FK_Course_Teacher FOREIGN KEY (TeacherID)
REFERENCES Teachers(ID);
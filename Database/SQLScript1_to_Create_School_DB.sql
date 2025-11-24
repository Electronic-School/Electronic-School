create DATABASE SchoolManagementDB;
GO

use SchoolManagementDB;
go


CREATE TABLE Parents(
	ParentsID INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	LocationId INT NOT NULL,
	PhoneNumber NVARCHAR(15),
	Email NVARCHAR(100),
	ChildrenInSchool INT
);-- we need to alter this table with address ( adding addres as a forgin key) 
GO

ALTER TABLE Parents
ADD CONSTRAINT FK_Parents_Location FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId);
GO


CREATE TABLE Students(
	StudentsId INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	LocationId INT NOT NULL,
	ParentID INT NOT NULL,

	CONSTRAINT FK_Student_Parent FOREIGN KEY (ParentID)
	REFERENCES Parents(ParentsID)
);

ALTER TABLE Students
ADD CONSTRAINT FK_Students_Location FOREIGN KEY (LocationId) 
REFERENCES Locations(LocationId);


CREATE TABLE Countries(
	CountryId INT PRIMARY KEY IDENTITY(1,1),
	CountryCode NCHAR(20) NOT NULL UNIQUE,
	CountryName NVARCHAR(50) NOT NULL, 
);
GO

CREATE TABLE Cities(
	CityId INT PRIMARY KEY IDENTITY(1,1),
	CityCode NCHAR(20) NOT NULL UNIQUE,
	CityName NVARCHAR(50) NOT NULL, 
);
GO

CREATE TABLE Locations(
	LocationId INT PRIMARY KEY IDENTITY(9,4),
	CountryId NOT NULL,
	CityId NOT NULL,
	Street VARCHAR(50) NOT NULL, 
	BuildingNo VARCHAR(30) NOT NULL,

	CONSTRAINT FK_Location_Country FOREIGN KEY (CountryId)
	REFERENCES Countries(CountryId),
	
	CONSTRAINT FK_Location_City FOREIGN KEY (CityId)
	REFERENCES Cities(CityId)
);


--this alter statement for who created the table previously 
ALTER TABLE Locations ADD culumn CountryCode FOREIGN KEY (CountryCode) REFERENCES Countries(CountryCode);
ALTER TABLE Locations ADD culumn CityCode FOREIGN KEY (CityCode) REFERENCES Cities(CityCode);
ALTER TABLE Locations ADD culumn PersonId FOREIGN KEY (PersonId) REFERENCES Person(PersonId);



CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    StartDate DATE,
    EndDate DATE,
    TeacherID INT NULL
);

ALTER TABLE Courses
ADD CONSTRAINT FK_Course_Teacher FOREIGN KEY(TeacherId)
REFERENCES Teachers(TeacherId);


CREATE TABLE Teachers (
    TeacherId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE,
	LocationId INT NOT NULL,
    Salary DECIMAL(10, 2),
	EducationDegree NVARCHAR(100) CHECK (EducationDegree IN('Bachelor degree','Master Degree')),
	TeachingSubject NVARCHAR(100),
    StartWorkingDate DATE,
    NumberOfVacations INT,
    PhoneNumber NVARCHAR(15),
    Email NVARCHAR(100) UNIQUE,
    SocialStatus NVARCHAR(50) CHECK (SocialStatus IN ('Single', 'Married')),
);

ALTER TABLE Teachers
ADD CONSTRAINT FK_Teachers_Location FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId);

ALTER TABLE Courses
ADD CONSTRAINT FK_Course_Teacher FOREIGN KEY (TeacherID)
REFERENCES Teachers(ID);


CREATE TABLE StudentGrades(
	StudentId INT NOT NULL,
	CourseId INT NOT NULL,
	ExamType NVARCHAR(50) NOT NULL, 
	Mark DECIMAL(5,2) CHECK (Mark >=0 AND Mark <= 100),
	-- composite primary key
	PRIMARY KEY (StudentId, CourseId, ExamType),

	CONSTRAINT FK_Grade_Student FOREIGN KEY (StudentId) REFERENCES Students(StudentsId),
	CONSTRAINT FK_Grade_Course FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);
GO


CREATE TABLE Attendance (
	AttendanceId INT PRIMARY KEY IDENTITY(1,1),
	PersonId INT NOT NULL,
	PersonType NVARCHAR(20) NOT NULL CHECK (PersonType IN ('Student','Teacher','Emp')),
	AttendanceDate DATE NOT NULL,
	AttendanceStatus NVARCHAR(20) NOT NULL CHECK (AttendanceStatus IN ('Present', 'Absent', 'Late', 'Excused')),

	UNIQUE (PersonId, PersonType, AttendanceDate)
);
GO

CREATE TABLE Employees (
	EmployeeId INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	LocationId INT NOT NULL,
	PhoneNumber NVARCHAR(15),
	Email NVARCHAR(100) UNIQUE,
	JopTitle NVARCHAR(50),
	Department NVARCHAR(50),
	HireDate DATE,
	Salary DECIMAL(10,2),
	--Status NVARCHAR(20),
	SocialStatus NVARCHAR(50) CHECK (SocialStatus IN ('Single', 'Married'))
);

ALTER TABLE Employees 
ADD CONSTRAINT FK_Employees_Location FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId);

-- ########################################################################################
CREATE TABLE Activities(
	ActivityID INT PRIMARY KEY IDENTITY(1,1),
	ActivityName  NVARCHAR(10),
	Description NVARCHAR(100),
	Schedule  NVARCHAR(100),
	Location   NVARCHAR(100)
);

CREATE TABLE  Curriculum(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50) NOT NULL, 
	Description  NVARCHAR(100)
); 

CREATE TABLE  StudentCouseEnrollment(
	StudentId INT NOT NULL,
	CourseId INT NOT NULL,
	EnrollmentDate DATE,
	Attendance NVARCHAR(20),
	FinalGrade VARCHAR(50),

	PRIMARY KEY (StudentId, CourseId),

	CONSTRAINT FK_StudentCourseEnrollment_Student FOREIGN KEY (StudentId)
	REFERENCES Students(StudentsId),
	
	CONSTRAINT FK_StudentCourseEnrollment_Course FOREIGN KEY (CourseId)
	REFERENCES Courses(CourseId)
);


ALTER TABLE Courses
ADD CurriculumID INT NULL;

ALTER TABLE Courses
ADD CONSTRAINT FK_Courses_Curriculum
FOREIGN KEY (CurriculumID)
REFERENCES Curriculum(Id);

ALTER TABLE Activities 
ADD SupervisorId INT NULL;

ALTER TABLE Activities
ADD CONSTRAINT FK_Activities_Supervisor
FOREIGN KEY (SupervisorID)
REFERENCES Employees(EmployeeId);
create DATABASE SchoolManagementDB;
GO

use SchoolManagementDB;
go


CREATE TABLE Parents(
<<<<<<< HEAD
	ParentsID INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	LocationId INT NOT NULL,
	PhoneNumber NVARCHAR(15),
	Email NVARCHAR(100),
	ChildrenInSchool INT
);-- we need to alter this table with address ( adding addres as a forgin key) 
=======
  ParentsID INT PRIMARY KEY IDENTITY(1,1),
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  DateOfBirth DATE,
  LocationId INT NOT NULL,
  PhoneNumber NVARCHAR(15),
  Email NVARCHAR(100),
  ChildrenInSchool INT
);
GO


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
  CountryId INT NOT NULL,
  CityId INT NOT NULL,
  Street VARCHAR(50) NOT NULL, 
  BuildingNo VARCHAR(30) NOT NULL,

  CONSTRAINT FK_Location_Country FOREIGN KEY (CountryId)
  REFERENCES Countries(CountryId),
  
  CONSTRAINT FK_Location_City FOREIGN KEY (CityId)
  REFERENCES Cities(CityId)
);
GO

ALTER TABLE Parents
ADD CONSTRAINT FK_Parents_Location FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId);
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
GO

ALTER TABLE Parents
ADD CONSTRAINT FK_Parents_Location FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId);
GO


CREATE TABLE Students(
<<<<<<< HEAD
	StudentsId INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	LocationId INT NOT NULL,
	ParentID INT NOT NULL,

	CONSTRAINT FK_Student_Parent FOREIGN KEY (ParentID)
	REFERENCES Parents(ParentsID)
=======
  StudentsId INT PRIMARY KEY IDENTITY(1,1),
  FirstName VARCHAR(50) NOT NULL,
  LastName VARCHAR(50) NOT NULL,
  DateOfBirth DATE,
  LocationId INT NOT NULL,
  ParentId INT NOT NULL,

  CONSTRAINT FK_Student_Parent FOREIGN KEY (ParentId)
  REFERENCES Parents(ParentsID)
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
);

ALTER TABLE Students
ADD CONSTRAINT FK_Students_Location FOREIGN KEY (LocationId) 
REFERENCES Locations(LocationId);

<<<<<<< HEAD

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
=======
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357


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
<<<<<<< HEAD
	LocationId INT NOT NULL,
    Salary DECIMAL(10, 2),
	EducationDegree NVARCHAR(100) CHECK (EducationDegree IN('Bachelor degree','Master Degree')),
	TeachingSubject NVARCHAR(100),
=======
  LocationId INT NOT NULL,
    Salary DECIMAL(10, 2),
  EducationDegree NVARCHAR(100) CHECK (EducationDegree IN('Bachelor degree','Master Degree')),
  TeachingSubject NVARCHAR(100),
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
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
<<<<<<< HEAD
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
=======
ADD CONSTRAINT FK_Course_Teacher FOREIGN KEY(TeacherId)
REFERENCES Teachers(TeacherId);


CREATE TABLE StudentGrades(
  StudentId INT NOT NULL,
  CourseId INT NOT NULL,
  ExamType NVARCHAR(50) NOT NULL, 
  Mark DECIMAL(5,2) CHECK (Mark >=0 AND Mark <= 100),
  -- composite primary key
  PRIMARY KEY (StudentId, CourseId, ExamType),

  CONSTRAINT FK_Grade_Student FOREIGN KEY (StudentId) REFERENCES Students(StudentsId),
  CONSTRAINT FK_Grade_Course FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
);
GO


CREATE TABLE Attendance (
<<<<<<< HEAD
	AttendanceId INT PRIMARY KEY IDENTITY(1,1),
	PersonId INT NOT NULL,
	PersonType NVARCHAR(20) NOT NULL CHECK (PersonType IN ('Student','Teacher','Emp')),
	AttendanceDate DATE NOT NULL,
	AttendanceStatus NVARCHAR(20) NOT NULL CHECK (AttendanceStatus IN ('Present', 'Absent', 'Late', 'Excused')),

	UNIQUE (PersonId, PersonType, AttendanceDate)
=======
  AttendanceId INT PRIMARY KEY IDENTITY(1,1),
  PersonId INT NOT NULL,
  PersonType NVARCHAR(20) NOT NULL CHECK (PersonType IN ('Student','Teacher','Emp')),
  AttendanceDate DATE NOT NULL,
  AttendanceStatus NVARCHAR(20) NOT NULL CHECK (AttendanceStatus IN ('Present', 'Absent', 'Late', 'Excused')),

  UNIQUE (PersonId, PersonType, AttendanceDate)
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
);
GO

CREATE TABLE Employees (
<<<<<<< HEAD
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
=======
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
  SocialStatus NVARCHAR(50) CHECK (SocialStatus IN ('Single', 'Married'))
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
);

ALTER TABLE Employees 
ADD CONSTRAINT FK_Employees_Location FOREIGN KEY (LocationId)
REFERENCES Locations(LocationId);

-- ########################################################################################
CREATE TABLE Activities(
<<<<<<< HEAD
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
=======
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
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
);


ALTER TABLE Courses
<<<<<<< HEAD
ADD CurriculumID INT NULL;

ALTER TABLE Courses
ADD CONSTRAINT FK_Courses_Curriculum
FOREIGN KEY (CurriculumID)
=======
ADD CurriculumId INT NULL;

ALTER TABLE Courses
ADD CONSTRAINT FK_Courses_Curriculum
FOREIGN KEY (CurriculumId)
>>>>>>> 23820c2429b2110b073fdd596eb903e842167357
REFERENCES Curriculum(Id);

ALTER TABLE Activities 
ADD SupervisorId INT NULL;

ALTER TABLE Activities
ADD CONSTRAINT FK_Activities_Supervisor
<<<<<<< HEAD
FOREIGN KEY (SupervisorID)
REFERENCES Employees(EmployeeId);
=======
FOREIGN KEY (SupervisorId)
REFERENCES Employees(EmployeeId);

>>>>>>> 23820c2429b2110b073fdd596eb903e842167357

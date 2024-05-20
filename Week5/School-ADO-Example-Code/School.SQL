CREATE SCHEMA School;
GO 

CREATE TABLE School.Students(
    Id int PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    email NVARCHAR(255),
    phone NVARCHAR(15),
    address1 NVARCHAR(255) NOT NULL,
    address2 NVARCHAR(255),
    city NVARCHAR(255) NOT NULL,
    state NVARCHAR(255) NOT NULL,
    zip int NOT NULL,
    age int NOT NULL,
    yearsCompleted int NOT NULL
)

CREATE TABLE School.Teachers(
    Id int PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    email NVARCHAR(255),
    phone NVARCHAR(15),
    address1 NVARCHAR(255) NOT NULL,
    address2 NVARCHAR(255),
    city NVARCHAR(255) NOT NULL,
    state NVARCHAR(255) NOT NULL,
    zip int NOT NULL,
    age int NOT NULL,
    subject NVARCHAR(255) NOT NULL,
    room NVARCHAR(255),
    tenure BIT NOT NULL,
    salary DECIMAL NOT NULL,
)

CREATE TABLE Certifications(
    Id int PRIMARY KEY IDENTITY,
    Name NVARCHAR(255) NOT NULL
)

CREATE TABLE TeacherCertification(
    Id int PRIMARY KEY IDENTITY,
    TeacherId int NOT NULL,
    CertificationId int NOT NULL
)

CREATE TABLE Courses(
    Id NVARCHAR(12) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Department NVARCHAR(255) NOT NULL,
    Location NVARCHAR(255) NOT NULL,
    StartDate DATETIME NOT NULL,
    CreditHours INT NOT NULL,
)

CREATE TABLE StudentCourses(
    Id INT PRIMARY KEY IDENTITY,
    StudentId INT NOT NULL,
    CourseID NVARCHAR(255) NOT NULL
)

CREATE TABLE Requirements(
    Id INT PRIMARY KEY IDENTITY,
    Req NVARCHAR(255) NOT NULL
)

CREATE TABLE CourseRequirements(
    Id INT PRIMARY KEY IDENTITY,
    CourseId NVARCHAR(255) NOT NULL,
    ReqId INT NOT NULL
)


SELECT * FROM School.Students;

-- DROP SCHEMA School;

-- DROP TABLE dbo.Certifications;
-- DROP TABLE dbo.CourseRequirements;
-- DROP TABLE dbo.Courses;
-- DROP TABLE dbo.Requirements;
-- DROP TABLE dbo.StudentCourses;
-- DROP TABLE dbo.TeacherCertification;
-- DROP TABLE School.Students;
-- DROP TABLE School.Teachers;
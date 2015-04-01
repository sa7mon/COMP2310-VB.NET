/* =======================================================================
Builds and populates tables for the WorkingWithJoins database.
Use as part of the Tutorial #21 Joins - http://mrbool.com/course/t-sql-step-by-step-course/382
-- ======================================================================= */

-- CREATE DATABASE WorkingWithJoins
-- GO

-- Make sure the Database selector (in the Toolbar) is set to WorkingWithJoins.
CREATE TABLE Student (
	-- Standard SQL syntax: Id int NOT NULL AUTO_INCREMENT,
	-- T-SQL syntax: IDENTITY(firstItemNumber, incrementBy)
	Id int NOT NULL IDENTITY(1,1),
	Name varchar(50) NULL,
	CourseId int NULL,
	PRIMARY KEY(Id)
)

CREATE TABLE Course (
	Id int NOT NULL IDENTITY(1,1),
	Descriptiopn varchar(50) NULL,
	CourseId int NULL,
	PRIMARY KEY(Id)
)

INSERT INTO Student VALUES('John', 1)
INSERT INTO Student VALUES('Jim', 2)
INSERT INTO Student VALUES('Lisa', 3)
INSERT INTO Student VALUES('Mike', 4)
INSERT INTO Student VALUES('Josh', 2)
INSERT INTO Student VALUES('Ayad', NULL)
INSERT INTO Student VALUES('Chris', NULL)
INSERT INTO Student VALUES('Liz', 5)
INSERT INTO Student VALUES('Zoey', 3)

INSERT INTO Course VALUES('Math 101',1)
INSERT INTO Course VALUES('English 101',2)
INSERT INTO Course VALUES('Economics 1002',3)
INSERT INTO Course VALUES('Political Science 1001',4)
INSERT INTO Course VALUES('Computer Science 1001',5)
INSERT INTO Course VALUES('Java',6)
INSERT INTO Course VALUES('C#',7)
INSERT INTO Course VALUES('SQL Server',8)

SELECT * FROM Student
SELECT * FROM Course



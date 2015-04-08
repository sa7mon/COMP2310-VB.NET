-----------------------------
-- Project: SQL
-- Created by: Dan Salmon (https://danthesalmon.com/)
-- Contact: dan.salmon@my.southcentral.edu
-- Created on: 4/2/15
-----------------------------

PRINT 'Project: SQL by Dan Salmon';

-- 1. Choose a database
SELECT db_name() as Name;

-- 2. Count employees
SELECT COUNT(DISTINCT rowguid) as EmployeeCount FROM Person.Person;

-- 3. List Person Types
SELECT DISTINCT PersonType FROM Person.Person;

-- 4. List Emails by Last Name
SELECT 
	Person.Person.FirstName, 
	Person.Person.LastName, 
	Person.EmailAddress.EmailAddress
FROM Person.Person
JOIN Person.EmailAddress
ON Person.Person.BusinessEntityID=Person.EmailAddress.BusinessEntityID
WHERE Person.Person.LastName LIKE 'L%'; 

-- 5. List Products 
SELECT prod.Name AS ProductName,sub.Name AS SubCategoryName
FROM Production.Product AS prod
JOIN Production.ProductSubCategory AS sub
ON prod.ProductSubcategoryID=sub.ProductCategoryID
ORDER BY sub.Name;

-- 6. Display Inventory using Grid

-- 7. Add a new table
IF  NOT EXISTS (SELECT * FROM sys.tables
WHERE name = N'personalDay' AND type = 'U')

	BEGIN
		CREATE TABLE personalDay
			(
				id				 INT		IDENTITY(1,1) PRIMARY KEY,
				type			 CHAR(25),
				NumberTaken		 INT,
				BusinessEntityID INT		FOREIGN KEY REFERENCES Person.Person(BusinessEntityID),
			)
	END

-- 8. Populate Table with Data
IF  NOT EXISTS (SELECT * FROM sys.tables
WHERE name = N'personalDay' AND type = 'U')
	BEGIN
		INSERT INTO PersonalDay (type, NumberTaken, BusinessEntityID)
		VALUES ('professional', 3, 1);
		INSERT INTO PersonalDay (type, NumberTaken, BusinessEntityID)
		VALUES ('personal', 2, 1);
		INSERT INTO PersonalDay (type, NumberTaken, BusinessEntityID)
		VALUES ('sick', 1, 1);
		INSERT INTO PersonalDay (type, NumberTaken, BusinessEntityID)
		VALUES ('personal', 14, 19970);
		INSERT INTO PersonalDay (type, NumberTaken, BusinessEntityID)
		VALUES ('sick', 0, 19970);
	END

-- 9. Display Personal Days Information
SELECT TOP(10)
		pers.FirstName, 
		pers.LastName,
		leave.type,
		leave.NumberTaken
FROM Person.Person as pers
JOIN personalDay as leave
ON pers.BusinessEntityID=leave.BusinessEntityID;
-- 10. Create own Personal SQL 

-- 11. Most Important Technique
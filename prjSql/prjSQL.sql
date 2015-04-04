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

/* 
As part of the HR input screen you want to create a dynamic drop-down 
list showing a list of each PersonType. If new PersonTypes are added to 
the database in the future this dropdown list will automatically include the new types.

Using the Person.Person table what SQL statement will give you a distinct
 list (each item being unique) of PersonType?
*/
SELECT DISTINCT PersonType FROM Person.Person;

-- 4. List Emails by Last Name
/*
HR wants a phone directory showing first name, last name, email. Due to the
 huge number of employees you decide to display the information based on 
 the last name initial.

Using Person.Person and any other tables you need show the SQL statement 
displaying the first name, last name, and email for all the people who's 
last name starts with "L". The list should be in alphabetical order by last name.

SELECT Person.Person.FirstName, Person.Person.LastName, Person.EmailAddress.EmailAddress
FROM Person.Person
FULL OUTER JOIN Person.EmailAddress
ON Person.Person.BusinessEntityID=Person.Person.BusinessEntityID
WHERE Person.Person.LastName LIKE 'L%'; 
*/

-- 5. List Products 
/*
You are building a mobile app for the sales department that will
allow them to quickly look up the different models that are available based on categories.
You plan to do a quick demo by putting this information in a grid. Later you will refine the
interface using drop­downs and other niceties.

Using the Production.Product and Production.ProductSubcategory tables, write a SQL
statement that will show the name of each product and it's category.
Use a JOIN
Use an alias of prod for the Product table
Use an alias of sub for the ProductSubcategory table
Use an alias of Category for the ProductSubcategory.name field
Order the grid by the ProductSubcategory.name field. (Tip: Use the full name, not
the alias)

*/
SELECT prod.Name AS ProductName,sub.Name AS SubCategoryName
FROM Production.Product AS prod
JOIN Production.ProductSubCategory AS sub
ON prod.ProductSubcategoryID=sub.ProductCategoryID
ORDER BY sub.Name;
-- 6. Display Inventory using Grid

-- 7. Add a new table
/*
 HR has found out that due to federal regulations they have to specifically track personal days taken for every employee. There are three categories to
track, professional days, personal days, and sick days.

Use the IF EXISTS( ) function Using IF EXISTS( ) with T­SQL (look at posting by
veljasije) around any CREATE TABLE statements so an error is not triggered if the script
runs a second time.

Build a new table named personalDay containing the following information:
-id ­ integer, not null, auto­incrementing
-BusinessEntityID, integer, not null (based on the Person.BusinessEntityID and Person.person
-type, string with 25 characters
-NumberTaken, integer
-id should be the primary key
*/
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
/* 

*/
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
-- 9. Display Personal Days Information
SELECT  pers.BusinessEntityID, 
		pers.FirstName, 
		pers.LastName,
		leave.type,
		leave.NumberTaken
FROM Person.Person as pers
JOIN personalDay as leave
ON pers.BusinessEntityID=leave.BusinessEntityID;
-- 10. Create own Personal SQL 

-- 11. Most Important Technique
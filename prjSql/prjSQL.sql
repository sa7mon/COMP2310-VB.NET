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
*/
SELECT Person.Person.FirstName, Person.Person.LastName, Person.EmailAddress.EmailAddress
FROM Person.Person
INNER JOIN Person.EmailAddress
ON Person.Person.BusinessEntityID=Person.Person.BusinessEntityID
WHERE Person.Person.LastName LIKE 'L%';

-- 5. List Products 

-- 6. Display Inventory using Grid

-- 7. Add a new table

-- 8. Populate Table with Data

-- 9. Display Personal Days Information

-- 10. Create own Personal SQL 

-- 11. Most Important Technique
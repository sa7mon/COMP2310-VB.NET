-----------------------------
-- Project: SQL
-- Created by: Dan Salmon (https://danthesalmon.com/)
-- Contact: dan.salmon@my.southcentral.edu
-- Created on: 4/2/15
-----------------------------
/*
11. Most Important Technique

 The most important SQL technique, in my opinion, is to work on big problems in small chunks.
 This is applicable in virtually every scenario where your query is more than one line. It's
 so important to take just a little bit of the query, run it, fix it, then add to that small part.
 Visual Studio makes this very easy by allowing you to highlight sections and run that portion.

*/

-- 0. Print the name of the project
--
PRINT 'Project: SQL by Dan Salmon';

-- 1. Choose a database
-- 
-- Outputs the name of the database currently connected to.
--
SELECT db_name() AS Name;


-- 2. Count employees
--
-- Simply returns the number of employees listen in Person.Person and 
-- gives the column an alias.
--
SELECT COUNT(DISTINCT rowguid) AS EmployeeCount FROM Person.Person;


-- 3. List Person Types
--
-- Returns all of the unique values for PersonType in Person.Person.
--
SELECT DISTINCT PersonType FROM Person.Person;


-- 4. List Emails by Last Name
--
-- Returns First Name, Last Name, and Email address for people with last
-- names that start with L. Gets the data from 2 different tables with the
-- column name BusinessEntityID in common.
--
SELECT 
	Person.Person.FirstName, 
	Person.Person.LastName, 
	Person.EmailAddress.EmailAddress
FROM Person.Person
JOIN Person.EmailAddress
ON Person.Person.BusinessEntityID=Person.EmailAddress.BusinessEntityID
WHERE Person.Person.LastName LIKE 'L%'; 


-- 5. Product Listing 
--
-- Returns product and sub category name joined on sub category ID and ordered by sub-category name.
--
SELECT prod.Name AS ProductName,sub.Name AS SubCategoryName
FROM Production.Product AS prod
JOIN Production.ProductSubCategory AS sub
ON prod.ProductSubcategoryID=sub.ProductCategoryID
ORDER BY sub.Name;


-- 6. Display Inventory using Grid
--
-- Returns many columns from 2 joined tables and gives them aliases.
--
SELECT 
	inven.ProductID,
	prod.name,
	prod.ProductNumber,
	inven.Quantity,
	inven.LocationID,
	inven.Shelf,
	inven.bin,
	prod.ReorderPoint,
	(prod.ReorderPoint - inven.Quantity) AS 'Items Before Reorder'
FROM Production.Product AS prod
JOIN Production.ProductInventory AS inven
ON prod.ProductID=inven.ProductID;


-- 7. Add a new table
--
-- Checks for the existance of a table with a certain name. If it doesn't exist,
-- creates on with 4 columns.
--
IF  NOT EXISTS (SELECT * FROM sys.tables
WHERE name = 'personalDay' AND type = 'U')
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
--
-- First, checks to see if table of certain name exist.
-- If it does, creates 5 rows but doesn't specify id because
-- the db engine will auto-increment to the next one.
--
IF EXISTS (SELECT * FROM sys.tables
WHERE name = 'personalDay' AND type = 'U')
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
--
-- Returns leave stats for the first 10 employees from the table we just created.
--
SELECT TOP(10)
		pers.FirstName, 
		pers.LastName,
		leave.type,
		leave.NumberTaken
FROM Person.Person AS pers
JOIN personalDay AS leave
ON pers.BusinessEntityID=leave.BusinessEntityID;


-- 10. Create own Personal SQL 
/*
 Scenario:  The marketing department needs some information about the current special offers to do 
			an email blast to the customer email mailing list. They will need product information,
			sale percentages, and pictures of the products to include in the email.
*/
SELECT TOP(100)
	offer.Description AS 'SpecialOfferName',
	offer.DiscountPct,
	offer.type AS 'OfferType',
	offer.StartDate,
	offer.EndDate,
	offer.MinQty,
	offer.MaxQty,
	OfferProduct.ProductID,
	product.Name,
	product.StandardCost,
	product.ProductNumber,
	Photo.ThumbnailPhotoFileName
FROM Sales.SpecialOffer AS offer
-- Add the columns from the Sales.SpecialOfferProduct table using the OfferProduct alias.
JOIN Sales.SpecialOfferProduct As OfferProduct
	ON offer.SpecialOfferID=offerProduct.SpecialOfferID
-- Add the columns from the Production.Product table using the product alias.
JOIN Production.Product As product
	ON product.ProductID=OfferProduct.ProductID
-- Use the Production.ProductProductPhoto table as a connection to the ProductPhoto table.
-- We don't actually need to select any columns from this table.
JOIN Production.ProductProductPhoto
	ON Production.ProductProductPhoto.ProductID=product.ProductID
-- Add the columns from the Production.ProductPhoto table using the Photo alias.
JOIN Production.ProductPhoto As Photo
	ON Production.ProductProductPhoto.ProductPhotoID = Photo.ProductPhotoID
-- Skip the "No special offer" entry
WHERE offer.SpecialOfferID >1
-- Order by the highest discout.
ORDER BY DiscountPct DESC
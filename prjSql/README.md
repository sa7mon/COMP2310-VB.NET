# Project: SQL

## Requirements
Using Visual Studio (or SQL Server Management Studio) and the AdventureWorks2012 database, write SQL statements for the following scenarios.

* Save your work as a file named prjSQL.sql
* At the top of the file include a multi-line comment block with your name, email, the date written and revision notes.
* Your instructor will be running your script to see the results. Make sure there are no errors when your file runs.
* Use the PRINT keyword to display the title of the script as part of the output
* Comment each SQL statement with a short summary showing the title of scenario (listed below) as well as what the SQL statement is doing.
* Each SQL keywords and functions should be ALL CAPS in your SQL file. This will demonstrate that you know the SQL keywords vs. table and field names.
* Each numbered item below will be worth 5 points.
## Specifications

1. **Choosing a Database** - You need to make certain that you are using the correct database. Write some SQL statements to use the AdventureWorks2012 database.

   ---
2. **Counting Employees** - You are creating a page enabling Human Resources (HR) to add new employees to the database. The HR Director wants the current number of employees to display on the page.
   Using the Person.Person table use a SQL function to find the current total of people listed in the database.
   
   ---
3. **List Person Types** - As part of the HR input screen you want to create a dynamic drop-down list showing a list of each PersonType. If new PersonTypes are added to the database in the future this dropdown list will automatically include the new types.
Using the Person.Person table what SQL statement will give you a distinct list (each item being unique) of PersonType?
   ---
4. **Email Listing by Last Name** - HR wants a phone directory showing first name, last
name, email. Due to the huge number of employees you decide to display the information
based on the last name initial. Using Person.Person and any other tables you need show the SQL statement displaying the first name, last name, and email for all the people who's last name starts with "L". The list should be in alphabetical order by last name.
   ---
5. **Product Listing**- You are building a mobile app for the sales department that will allow them to quickly look up the different models that are available based on categories. You plan to do a quick demo by putting this information in a grid. Later you will refine the interface using drop-downs and other niceties.

   Using the Production.Product and Production.ProductSubcategory tables, write a SQL
statement that will show the name of each product and it's category.
   * Use a JOIN
   * Use an alias of prod for the Product table
   * Use an alias of sub for the ProductSubcategory table
   * Use an alias of Category for the ProductSubcategory.name field
   * Order the grid by the ProductSubcategory.name field. (Tip: Use the full name, not    the alias)
   ---
6. **Display Current Inventory Using a Grid** - The warehouse manager has sent in a request asking for a page that shows the current inventory as including quantity when to re-order. You decide to do this using the Database Gridview.

   Using Production.ProductInventory and Production.Product include the following
information in the grid:
   * Columns should be ProductID, Name, ProductNumber, Quantity, LocationID, Shelf,
Bin, ReorderPoint, Items Before Reorder
   * Items Before Reorder is an alias and uses the formula reorderPoint - quantity
   * ProductInventory should use the alias inven
   * Product should use the alias prod
   * The Database Gridview control will automatically sort data by clicking on the column
headings so you don't have to worry about sorting the data (unless the Warehouse
person comes back later and wants it to initially show up in a specific order.)
   ---
7. **Adding in a new Table** - HR has found out that due to federal regulations they have to specifically track personal days taken for every employee. There are three categories to track, professional days, personal days, and sick days.

   Use the IF EXISTS( ) function [Using IF EXISTS( ) with T-SQL (look at posting by
veljasije)](http://stackoverflow.com/a/13745792) around any CREATE TABLE statements so an error is not triggered if the script runs a second time.

   Build a new table named personalDay containing the following information:
   * id - integer, not null, auto-incrementing
   * BusinessEntityID, integer, not null (based on the Person.BusinessEntityID and Person.person
   * type, string with 25 characters
   * NumberTaken, integer
   * id should be the primary key
   ----
8. **Populate a Table With Data*** - You create an online-form that employees can use to record their personal days. The form includes the person's BusinessEntityID, a dropdown with the three types of leave, and spinner allowing them to list how many days. When the employee clicks the okay button you will use SQL to add this information to the new table.
   * The person with BusinessEntityID #1 used 3 days for professional duties by attending a conference.
   * The person with BusinessEntityID #1 used 2 days for personal reasons.
   * The person with BusinessEntityID #1 used 1 day due to the flu.
   * The person with BusinessEntityID #19970 used 14 days for personal reasons.
   * The person with BusinessEntityID #19970 used 0 days for a doctor visit.
   ---
9. **Display Personal Days Information** - HR also needs a report that will show the
personal days that everyone has taken. Write a SQL statement that shows:
   * The employee's BusinessEntityID
   * The employee's first and last name
   * The type of leave
   * The number of days taken.
   * Group these by the employee's BusinessEntityID
   * Use aliases for each table used
   ---
10. **Create Your Own SQL Scenario** - Think of a scenario that will require a SQL
statement that does the following. Describe the scenario as a comment block above the
actual SQL statement(s) you used.
    * Pulls in data from at least three different tables (How to do multiple joins)
    * Uses aliases
    * Uses the keyword TOP
    ---
11. **Most Important Technique** - As a comment block near the top of the file describe
what you think is the most important SQL technique you've learned and describe a
scenario where you would use this technique.




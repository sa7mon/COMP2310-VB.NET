-- =========================================
-- Create userDatabase Windows Azure SQL Database 
-- =========================================
USE userDatabase
GO

IF OBJECT_ID('userTable', 'U') IS NOT NULL
  DROP TABLE userTable
GO
CREATE TABLE userTable
(
id int NOT NULL IDENTITY(1,1),
userID varchar(30),
userName varchar(25),
password varchar(25),
email varchar(30),
phone varchar(12),
PRIMARY KEY(id),
)

-- Populate the table
INSERT INTO userTable (userID, userName, password, email, phone)
VALUES('hg01','hermione.granger','Please99!', 'hermione123@gmail.com','5559087654')

INSERT INTO userTable (userID, userName, password, email, phone)
VALUES('sever02','severus.snape','Please99!', 'ssnape@gmail.com','3457890223')

INSERT INTO userTable (userID, userName, password, email, phone)
VALUES('ginny03','ginny.weasley','Please99!', 'ginnywe@gmail.com','1346667890')

INSERT INTO userTable (userID, userName, password, email, phone)
VALUES('sirius04','sirius.black','Please99!', 'sblack@gmail.com','6667798080')

INSERT INTO userTable (userID, userName, password, email, phone)
VALUES('nev05','neville.longbottom','Please99!', 'nlongbot@gmail.com','3353387900')

INSERT INTO userTable (userID, userName, password, email, phone)
VALUES('miner06','minerva.mcgonagall','Please99!', 'minnymcgon@gmail.com','3353387904')


SELECT SUBSTRING(phone,1,3)+'-'
+SUBSTRING(phone,4,3)+'-'
+SUBSTRING(phone,7,4) AS Phone FROM userTable



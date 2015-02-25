#Project: DecisionString
##Summary
Make programming decisions using the If Then/Else, Select Case, and ternary constructs.

* Make a yes/no decision using the If Then/Else statement
* Use the iif (immediate if) function to make a one line if else decision
* Compare a value against multiple options with the Select Case statement
* Use Class and Private variables appropriately

##Requirements
An Internet Service Provider (ISP) offers three subscription packages to its customers, plus a discount for non-profit organizations. The owner wants a program that will allow his staff to quickly calculate the monthly charges for each customer based on usage, pricing tier, and if they are a non-profit or not.

Here is what the pricing tiers look like:

| Package Name | Price | Additional Hours |
| -------------|-------|------------------ |
| Fast         | 	10 hrs/month at $9.95/month	| $2.00 |
|Faster		 | 20 hrs/month at $14.95/month | $1.00 |
|Fastest		 | Unlimited Access at $19.95/month | no extra charge |
|Non-Profit Discount	| 20% off any package | 20% off |

##Code Requirements
* Create a form that allows the user to input how many hours they used for a month. (Use a default value of 25 hours) as well as a set of radio buttons allowing him or her to select a pricing package.
* Add text boxes for first name, last name, and phone numbers. Include default values for development and testing (and grading).
Include a checkbox for non-profit organizations.
* Using a set of if then elseif statements, calculate the total amount using the chart above. If the user checks the non-profit checkbox, subtract 20% off the total cost.
* Display the original total as well as the discounted amount. Make certain everything is clearly labeled for the user.
* Use the iif( ) to determine what title should be displayed "Monthly Charge" or "Discounted Monthly Charge".
* All rates, limits, and discount values must be declared as symbolic constants using the proper keyword and capitalization that you learned in the Learning Activities. Include these near the top of your code so they can be easily modified.
* Validate the user input. There cannot be more than 744 hours used per month. The value must be numeric.
* In a text document write out test data for various combinations. Use "smart" data and show regular prices, extended prices (more than base hours used), as well as the discount price. Do this for each of the three pricing tiers.

Use the following chart as a starting guide, setting up three test cases for each pricing tier:

| Package Name | Price | Expected Results |
---------------|-------|------------------|
| Fast | 10 hours | $9.95 |
| Fast, non-profit | 10 hours, non-profit | $7.96 (20% discount) |
| Fast | 12 hours | $13.95|

Using your test data, type in the hours and see if you get the expected results from your program.

Use the String Functions to create and display the user's account number using the following pattern: first three characters of first name (all lower case) - last four digits of the phone number - last three characters of last name (all lower case). 
For example:    Peter Johnson 507-389-7337 would be: pet-7337-son

As soon as the user types in the phone number text box (use the Leave event) reformat the input to a format that looks like this: 999-999-9999. Think through the problem before you start coding. Some possible input the user might give you is:
1234567890  (123) 456-7890  123.456.7890    123-456-7890 (the correct format)

In the Leave event add comments describing what you are going to do in English before you type the code.
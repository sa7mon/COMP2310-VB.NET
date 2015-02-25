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
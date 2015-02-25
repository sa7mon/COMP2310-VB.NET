#Project: SubFunction
##Summary:
This project is designed so you can demonstrate your specific knowledge in the
following areas:

* Utilize subroutines for greater code reuse
* Use parameters to send data to subroutines
* Write functions which return data
* Capture and use the data returned by a function using the assignment operator
* Read XML data from a text file
* Parse through XML data
* Create reusable modules

##Code Requirements
###XML and Function Specs

1. Create an XML document named myCollection.xml describing something you
collect. This could be books, CDs, games, or any other type of collection. This will
be a plain text file and should include at least five items. You can use any text editor such as TextPad or Visual Studio.
2. Create an simple VB form named frmCollection that displays the information from
the XML document when the user clicks a button.
3. Write a function named dashConcat( ) that accepts at least three items from your
XML document. The function should concatenate the items together with a space
dash space " ­ " in between each item and return this as a String to the calling
function.
4. Add a button to your form named btnDashConcat. When the user clicks this button it
will call a subroutine that extracts items from the XML document. It will then call the
function, passing it the items, and display the results on the screen along with a
descriptive label for great UX.

###ByRef vs ByVal Specs:
1. Write a subroutine named demoByRef( ) that demonstrates you understanding of
the keywords: ByVal and ByRef
  * The sub should accept two strings.
  * The first string should be passed by value.
  * The second string should be passed by reference.
  * Inside the sub change both strings and display the original value and the
new value. Label these so it is clear the output is from inside the sub.
2. Create two private String variables.
3. Call the subroutine demoByRef( ) passing in the two private variables.
4. After the function runs, display both variables on the screen labeling them so it is
clear that the output is after the subroutine has run.
5. In a multi­line label (a textbox set to read­only), display a sentence or two describing what happened to the two private variables and why showing your understanding of
ByVal and ByRef. What happens if these two variables were global?

###Using A Module Specs:
1. Create a form that displays a high score number and a button. When the user clicks
the button, generate a random number. ([Using Rnd( )](https://msdn.microsoft.com/en-us/library/f7s023d2%28v=vs.90%29.aspx)) Call a method (located in a
module) to see if the new number is a new high score.
2. Create a module with a function that accepts the number from the form and
compares it to a static variable to see if the new number is a new high score. If it is,
update the variable and display the new high score on the form.
3. Later, you can replace the button with your own arcade video game written in
VB.NET, keeping track of everyone's high score! (But, for now, just get the high
score mechanism working.)
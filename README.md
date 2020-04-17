# Homework_2
 A project to calculate the amount of a book sale order based on quantity and price of a given book.  Sales tax and shipping charges will apply.
 
Form: 
Using text boxes for the title, quantity and price of a book. Use radio buttons to indicate whether sales tax should apply. 
Results are output to labels or text boxes and formatted as currency.
Included buttons for Calculate, Clear, and Exit

Code: 
All data fields are validated.  Title is required, Quantity and Price are numeric.

Project contain FOUR methods.
A function to calculate and return the extended price based on quantity and price.
extended price is quantity * price
A function to calculate and return the shipping amount based on the extended price
if cost of order is 0-100, the shipping is $15, if order is 101-250, the shipping is $25, if the order is 251-500, the shipping is $40, if the order is > 500 the shipping is free.
A subroutine to calculate sales tax.  it should have 2 parameters: extended price and sales tax.  The sales tax should be passed by reference.
if selected, sales tax should be 0.0725 of the extended price.
A subroutine to display the totals accepting 3 parameters of extended price, shipping, and sales tax

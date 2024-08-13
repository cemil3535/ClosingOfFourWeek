# ClosingOfFourWeek

Phone -> Has the features of Production Date, Serial Number, Name, Description, Operating System, Tr Licensed or not.

Computer -> Has the features of Production Date, Serial Number, Name, Description, Operating System, USB Port Count, Bluetooth or not.

Give inheritance from a BaseClass named BaseMachine to Phone and Computer classes. (Inheritance)

For Computer, the USB port count can be assigned as 2 or 4, otherwise a warning message is given and a value of -1 is assigned. (Encapsulation)

Let the Production Date value be assigned automatically when an object is created. It is valid for both Phone and Computer.

In the Base Class (BaseMachine), define a PrintInformation() method that prints common information such as Production Date, Serial Number, Name, Description, Operating System. In Derived classes (Phone, Computer), this method is overridden and the print function that belongs to them is added to the Base function. (Polymorphism)

Define an abstract method called GetProductName() and print console messages separately for Phone and Computer

"Your phone name ---> ......"

"Your computer name ---> ......"

(Abstraction)

Program flow:

1- Tell the user from the console screen that they need to press 1 to produce a phone and 2 to produce a computer.

2- Create an object from the relevant class according to the user's choice and get its properties from the console screen, that is, from the user.

3- When all the information is entered, notify with a message that the product has been successfully produced and ask if they want to produce another product.

4- If the user answers yes, go back to step 1, if they answer no, wish them a good day and end the application

*** This project coded C#

# Event-Example C#
This is just a simple event handler example, made so somone would understand it's simplest use. It is made of three parts:

Transaction, this holds the number of transactions, (set to 999990 for convenience).   
Three is an event handler.  
There is a method that simulates a transaction.  
When the simulation notices that there is a million transactions it invokes the event handler.  

Staff, this holds a hypothetical member of staff.  
The member of staff has a name, and is automatically subscrived to the event handler in the transaction.  
This member of staff also as a method of what to do if they are ever told about there being a millionth transaction.  

Program.  
We say that a member of staff is working... it is Jane if anyone cares.  
We then have an infinite loop in which  we simulate a transaction every time the enter key is pressed.  

999990  
999991  
... bla bla bla ...  
999999  
1000000 ... Jane congratulates the buyer on making the 1 millionth transaction.  

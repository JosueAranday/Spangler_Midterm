# CITP 4350 Midterm

Create an “Employee” class with six fields: first name, last name, workID, yearStartedWked, initSalary, and curSalary. It includes constructor(s) and properties to initialize values for all fields (curSalary is read-only). It also includes a calcCurSalary function that assigns the
curSalary equal to initSalary. 

## Create a “Worker” classes that are derived from Employee class.

1. In Worker class, it has one field, yearWorked. It includes constructor(s) and properties. It also includes two functions: first, calcYearWorked function, it takes one parameter (currentyear) and calculates the number of year the worker has been working (current
year–yearStartedWked) and save it in the yearWorked variable. Second, the calcCurSalary function that calculate the current year salary by overriding the base class function using initial salary with 3% yearly increment.

## Create a “Manager” classes that are derived from Worker class.

2. In Manager class, it includes one field: yearPromo. It includes the constructor(s) and property. It also includes a calcCurSalary function that calculate the current year salary by overriding the base class function using initial salary with 5% yearly increment plus 10% bonus. The manager’s salary calculates in two parts. It calculates as a worker
before the year promoted and as a manager after the promotion.

## Create an “EmployeeDemo” class. It includes three functions:

1. In the main function, the program calls the readData() function to get the data from file and calls the objSort() function to sort the array of objects. Then, the program prompts user to enter the range of current salary that user want to see and display the employee’s information whose current salary is in the range in a descending order.

2. readData(): it reads the workers and managers information from files (“worker.txt” and “manager.txt”) and then creates the dynamic arrays of objects to save the data. Then, it prompts user for the current year to calculate the yearWorked and currentSalary.

3. objSort(): this function accepts an array of object as a parameter and sort the array by current salary in descending order.

## P.S.: In the text files, they include the number of people in the files at the beginning of the files.

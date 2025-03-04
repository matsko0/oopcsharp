//# Class 2 Homework 📒
//## Task 1

//Create new console application called“RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
//* Test Data:
//  *Enter the First number: 10
//  * Enter the Second number: 15
//  * Enter the Operation: +
//*Expected Output:
//*The result is: 25

Console.WriteLine("Enter the first number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the operation ( +, - , * , / )");
char operation = Convert.ToChar(Console.ReadLine());

double result = 0;
bool validOperation = true;

switch (operation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if(num2 != 0)
            result = num1 / num2;
        else
        {
           Console.WriteLine("Error: Division by zero is not allowed.");
           validOperation = false;
        }
        break;

    default:
        Console.WriteLine("invalid operation");
        validOperation = false;
        break;
}
    if (validOperation)
    Console.WriteLine("The result is: " + result);
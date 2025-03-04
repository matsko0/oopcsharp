//## Task 3:

//Create new console application called “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:
//*Test Data:
//*Input the First Number: 5
//* Input the Second Number: 8
//* Expected Output:
//*After Swapping:
//*First Number: 8
//* Second Number: 5;

Console.WriteLine("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

num1 = num1 + num2;
num2 = num1 - num2;
num1 = num1 - num2;

Console.WriteLine("Swapping numbers from input: ");
Console.WriteLine("First number: " + num1);
Console.WriteLine("Second number: " + num2);

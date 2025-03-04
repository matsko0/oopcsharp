//## Task 2

//Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.
//* Test Data:
//  *Enter the First number: 10
//  * Enter the Second number: 15
//  * Enter the third number: 20
//  * Enter the four number: 30
//* Expected Output:
//*The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Enter the First number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Fourth number: ");
double num4 = Convert.ToDouble(Console.ReadLine());

double average = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");





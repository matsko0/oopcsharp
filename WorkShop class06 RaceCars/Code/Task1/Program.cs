//Create a method called NumberStats that accepts a number. This method should:

//Find out if the number is negative or positive

//Find out if the number is odd or even

//Find out if the number is decimal or integer

//After finding all the stats it should print them like this:

//Stats for number: 25

//Positive
//Integer
//Odd
//The number should be entered in the console by the user.

//Bonus: Validate if the user is entering a number

//Bonus: Ask the user to press Y to try again or X to exit

while (true)
{
    Console.WriteLine("Plase Enter a number");
    string input = Console.ReadLine();

    if(double.TryParse(input, out double number))
    {
        NumberStats(number);
    }
    else
    {
       Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    Console.WriteLine("Press Y to try again or X to exit:");

    string choice = Console.ReadLine().ToUpper();
    if (choice == "X")
    {
        Console.WriteLine("Exiting the program. Goodbye");
        break;
    } else if (choice != "Y") 
    {
        Console.WriteLine("enter Y to continue or X to exit.");
    }
}
static void NumberStats(double number)
{
    Console.WriteLine($"\nStats for number: {number}");

    Console.WriteLine(number > 0 ? "positive" : number < 0 ? "negative" : "zero");

    if (number % 1 == 0)
    {
        Console.WriteLine("Integer");

        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
    }
    else
    {
        Console.WriteLine("Decimal");
    }
}
//Homework Class 8 📒
//Task 1
//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the number in the order that the user entered them from the QUEUE


Queue<int> numbers = new Queue<int>();
string userInput = "";

do
{
    Console.Write("Enter a number: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        numbers.Enqueue(number);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    do
    {
        Console.Write("Do you want to enter another number? (Y/N): ");
        userInput = Console.ReadLine()?.Trim().ToUpper() ?? "";

        if (userInput != "Y" && userInput != "N")
        {
            Console.WriteLine("Invalid choice. Please enter 'Y' or 'N'.");
        }

    } while (userInput != "Y" && userInput != "N");

} while (userInput == "Y");

Console.WriteLine("\nNumbers in the order you entered:");

foreach (int num in numbers)
{
    Console.WriteLine(num);
}
//Homework Class 4 📒

//Task
//Make a method called AgeCalculator

//The method will have one input parameter, your birthday date

//The method should return your age

//Show the age of a user after he inputs a date

////Note: take into consideration if the birthday is today, after or before today
///

while (true)
{
    Console.WriteLine("Please enter your birthdate: (yyyy-mm-dd)");
    string input = Console.ReadLine();

    if (DateTime.TryParse(input, out DateTime birthDate))
    {
        int age = AgeCalculator(birthDate);
        Console.WriteLine($"Your age is: {age}");
    }
    else
    {
        Console.WriteLine("Invalid date format. Please enter in yyyy-mm-dd format.");
    }

    Console.WriteLine("Press Y to try again or X to exit:");
    string choice = Console.ReadLine().ToUpper();
    if (choice == "X")
    {
        Console.WriteLine("Exiting the program. Goodbye");
        break;
    }
    else if (choice == "Y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("enter Y to continue or X to exit.");
    }


    static int AgeCalculator(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;

        if (birthDate.Date > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }
}
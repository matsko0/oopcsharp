using ATM;


List<CardHolder> cardHolders = new List<CardHolder>();

void PrintOptions()
{
    Console.WriteLine("Please choose one from the following options...");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Show Balance");
    Console.WriteLine("4. Exit");
}

void RegisterNewCard()
{
    Console.WriteLine("Enter new card number: input format (1234-1234-1234-1234)");
    string cardInput = Console.ReadLine().Replace("-", "");
    if (cardInput.Length == 16 && cardInput.All(char.IsDigit))
    {
        if (cardHolders.Any(ch => ch.GetCardNum() == cardInput))
        {
            Console.WriteLine("Card number already exists. Try again.");
            return;
        }


        Console.Write("Enter a 4-digit PIN: ");

        if (int.TryParse(Console.ReadLine(), out int pin) && pin >= 1000 && pin <= 9999)
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");

            string lastName = Console.ReadLine();

            cardHolders.Add(new CardHolder(cardInput, pin, firstName, lastName, 0));
            Console.WriteLine("Registration successful! Please log in.");
        }
        else
        {
            Console.WriteLine("Invalid PIN format- try again!");
        }
    }
}
void Deposit(CardHolder currentUser)
{
    Console.WriteLine("How much money would you like to deposit? ");
    if (double.TryParse(Console.ReadLine(), out double deposit) && deposit > 0)
    {
        currentUser.SetBalance(currentUser.GetBalance() + deposit);
        Console.WriteLine($"Thank you for your money. Your new balance is: {currentUser.GetBalance()} ");

    }
    else
    {
        Console.WriteLine("Invalid input please put a valid amount!");
    }
}

void Withdraw(CardHolder currentUser)
{
    Console.WriteLine("How much money would you like to withdraw? ");
    if (double.TryParse(Console.ReadLine(), out double withdrawl) && withdrawl > 0)
    {
        if (currentUser.GetBalance() < withdrawl)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            currentUser.SetBalance(currentUser.GetBalance() - withdrawl);
            Console.WriteLine($"Thank you for your money. Your new balance is: {currentUser.GetBalance()} ");

        }
    }
    else
    {
        Console.WriteLine("Invalid input please put a valid amount!");
    }

}

void ShowBalance(CardHolder currentUser)
{
    Console.WriteLine("Current balance: " + currentUser.GetBalance());
}

cardHolders.Add(new CardHolder("1233211233211234", 1234, "Martin", "Martinovic", 2200.31));
cardHolders.Add(new CardHolder("1333211233211234", 1234, "Stefan", "Stefanovic", 1600.23));
cardHolders.Add(new CardHolder("1433211233211234", 1234, "Marina", "Marinovic", 2500.11));
cardHolders.Add(new CardHolder("1533211233211234", 1234, "Bojana", "Bojanovic", 1200.66));
cardHolders.Add(new CardHolder("1633211233211234", 1234, "Svetlana", "Svetlanovic", 1100.06));


while (true)
{
    Console.WriteLine("Welcome to the ATM app");
    Console.WriteLine("Choose: \n 1 to Login: \n 2 to Register a new card: \n 3 to Exit program ");
    string choice = Console.ReadLine();
    if (choice == "2")
    {
        RegisterNewCard();
        continue;
    }
    else if (choice == "3") { break; }

    Console.Write("Enter your card number (format: 1234-1234-1234-1234): ");
    string cardInput = Console.ReadLine().Replace("-", "");
    if (cardInput.Length != 16 || !cardInput.All(char.IsDigit))
    {
        Console.WriteLine("Invalid card format. Please enter a valid 16-digit card number.");
        continue;
    }
    CardHolder currentUser = cardHolders.FirstOrDefault(ch => ch.GetCardNum() == cardInput);
    if (currentUser == null)
    {
        Console.WriteLine("Card not recognized. Try again.");
        return;
    }

    Console.Write("Enter your PIN: ");
    if (int.TryParse(Console.ReadLine(), out int userPin) && currentUser.ValidatePin(userPin))
    {
        Console.WriteLine($"Welcome {currentUser.GetFirstName()}!");
    }
    else
    {
        Console.WriteLine("Incorrect PIN. Try again.");
        continue;
    }

    int option = 0;
    do
    {
        PrintOptions();
        if (int.TryParse(Console.ReadLine(), out option))
        {
            switch (option)
            {
                case 1: Deposit(currentUser); break;
                case 2: Withdraw(currentUser); break;
                case 3: ShowBalance(currentUser); break;
                case 4: break;
                default: Console.WriteLine("Invalid option. Please try again."); break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    } while (option != 4);
    Console.WriteLine("Thank you have a nice day :)");
}




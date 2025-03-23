//Task 2
//Create a class User with the following:

//Id - int
//Username - string
//Password - string
//Messages - Array of strings Create an array of users and add 3 users to it manually ( hard-coded ).
//Create a Console UI that will ask the user:

//Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
//Welcome NAME. Here are your messages:
//Message1
//Message2
//If not found, it should print an error message
//Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
//Registration complete! Users:
//23 Username1
//44 Username2
//1 Username3
//56 Username4**

class Program
{
    static List<User> users = new List<User>
        {
            new User { Id = 1, Username = "Eva", Password = "password123", Messages = new string[] { "Hello Eva!", "Whats up?" } },
            new User { Id = 2, Username = "Ava", Password = "password321", Messages = new string[] { "Your order has shipped Ava.", "You will arrive it soon." } },
            new User { Id = 3, Username = "Ova", Password = "mypassword1", Messages = new string[] { "Happy Birthday Ova!", "Wish you the best." } }
        };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    LogIn();
                    break;
                case "2":
                    Register();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }


    }
    static void LogIn()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        Console.WriteLine($"Attempting login for {username}");

        foreach (var user in users)
        {
            Console.WriteLine($"Checking user: {user.Username}");
            if (user.Username == username && user.Password == password)
            {
                Console.WriteLine($"User {username} logged in successfully.");
                Console.WriteLine($"Welcome {user.Username}. messages for you:");
            }
            foreach (var message in user.Messages)
            {
                Console.WriteLine(message);
            }
            return;
        }
        Console.WriteLine("Error: Incorrect username or password.");
    }
    static void Register()
    {
        Console.WriteLine("Enter ID");
        int id;
        while (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("Invalid id. enter a number id!");
        }
        Console.WriteLine("Enter username:");
        string input = Console.ReadLine();

        if (users.Any(x => x.Username == input))
        {
            Console.WriteLine("User found please enter anoter name");
            return;
        }
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        users.Add(new User { Id = id, Username = input, Password = password, Messages = new string[0] });
    }
}

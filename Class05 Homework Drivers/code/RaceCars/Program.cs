using RaceCars;
class Program
{
    static void RaceCars(Car car1, Car car2)
    {
        int speed1 = car1.CalculateSpeed();
        int speed2 = car2.CalculateSpeed();

        if (speed1 > speed2)
        {
            Console.WriteLine($"{car1.Model} driven by {car1.Driver.Name} won with a speed of {speed1}.");
        }
        else if (speed2 > speed1)
        {
            Console.WriteLine($"{car2.Model} driven by {car2.Driver.Name} won with a speed of {speed2}.");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }

    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Hyundai", 120),
            new Car("Mazda", 130),
            new Car("Ferrari", 200),
            new Car("Porsche", 180)
        };

        List<Driver> drivers = new List<Driver>
        {
            new Driver("Bob", 3),
            new Driver("Greg", 5),
            new Driver("Jill", 4),
            new Driver("Anne", 2)
        };

        bool raceAgain;
        do
        {
            Console.WriteLine("Choose a car no.1:");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            int car1Index = int.Parse(Console.ReadLine()) - 1;
            Car car1 = cars[car1Index];

            Console.WriteLine("Choose a driver for car no.1:");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            int driver1Index = int.Parse(Console.ReadLine()) - 1;
            car1.Driver = drivers[driver1Index];

            List<Car> remainingCars = new List<Car>(cars);
            remainingCars.RemoveAt(car1Index);

            Console.WriteLine("Choose a car no.2:");
            for (int i = 0; i < remainingCars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {remainingCars[i].Model}");
            }
            int car2Index = int.Parse(Console.ReadLine()) - 1;
            Car car2 = remainingCars[car2Index];

            Console.WriteLine("Choose a driver for car no.2:");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            int driver2Index = int.Parse(Console.ReadLine()) - 1;
            car2.Driver = drivers[driver2Index];

            RaceCars(car1, car2);

            string userInput;
            do
            {
                Console.WriteLine("Do you want to race again? (yes/no)");
                userInput = Console.ReadLine().Trim().ToLower();

                if (userInput != "yes" && userInput != "no")
                {
                    Console.WriteLine("Invalid input. Please type 'yes' to race again or 'no' to exit.");
                }
            } while (userInput != "yes" && userInput != "no");

            raceAgain = userInput == "yes";
        } while (raceAgain);
    }
}
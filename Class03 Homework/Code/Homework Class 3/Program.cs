
//Make a console application called SumOfEven.
//Inside it create an array of 6 integers. Get numbers from the input,
//find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.2:
//3
//Enter integer no.3:
//7
//Enter integer no.4:
//3
//Enter integer no.5:
//2
//Enter integer no.6:
//8
//Expected Output:
//The result is: 14


int[] numbers = new int[6];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Enter integer no.{i + 1}:\n");
    bool success = int.TryParse(Console.ReadLine(), out numbers[i]);
    if (!success)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        i--;
        continue;
    }
}
foreach (int num in numbers)
{
    if(num %2 == 0)
    {
        sum += num;
    }
}
Console.WriteLine($"The result is: {sum}");
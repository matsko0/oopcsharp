namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        public double SharesPrice { get; set; }

        public CEO(string name, double salary, int shares, Employee[] employees)
            : base(name, salary)
        {
            Shares = shares;
            Employees = employees;
            SharesPrice = 0;
        }

        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees");
            foreach (var employee in Employees)
            {
                employee.PrintInfo();
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"CEO:\nFirst Name: {Name.Split(' ')[0]}, Last Name: {Name.Split(' ')[1]}, Salary: {Salary}");
        }

    }
}

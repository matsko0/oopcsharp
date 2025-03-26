namespace Domain.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"First Name: {Name.Split(' ')[0]}, Last Name: {Name.Split(' ')[1]}, Salary: {Salary}");
        }
    }

    
}

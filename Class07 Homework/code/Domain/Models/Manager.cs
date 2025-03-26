namespace Domain.Models
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        
        public Manager(string name, double salary, string department) : base(name, salary)
        {
            Department = department;
        }
    }
}

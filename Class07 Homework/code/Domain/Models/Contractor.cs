namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string name, double workHours, int payPerHour, Manager responsible)
            :base (name, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Contractor: {Name}, Work Hours: {WorkHours}, Pay Per Hour: {PayPerHour}, Salary: {GetSalary()}, Manager: {Responsible.Name} ({Responsible.Department} Department)");
        }

    }
}

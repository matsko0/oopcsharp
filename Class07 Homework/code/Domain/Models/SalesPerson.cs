
namespace Domain.Models
{
    public class SalesPerson : Employee
    {
        public int Commision { get; set; }

        public SalesPerson(string name, double salary, int commision)
            : base(name, salary)
        {
            Commision = commision;
        }

        public override double GetSalary()
        {
            return Salary + Commision;    
        }
    }
}

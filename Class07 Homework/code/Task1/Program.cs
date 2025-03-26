using Domain.Models;

Manager manager1 = new Manager("Bob Bobert", 7000, "IT");
Manager manager2 = new Manager("Rick Rickert", 7500, "HR");

Contractor contractor1 = new Contractor("Mona Monalisa", 160, 30, manager1);
Contractor contracto2 = new Contractor("Igor Igorsky", 150, 25, manager2);

SalesPerson salesPerson = new SalesPerson("Lea Leova", 2000, 500);

Employee[] company = {manager1, manager2, contractor1, contracto2, salesPerson};

CEO ceo = new CEO("Ron Ronsky", 1500, 100, company);

ceo.AddSharesPrice(14);

Console.WriteLine("INFO:");
ceo.PrintInfo();

Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");

Console.WriteLine($"Employees are:");
ceo.PrintEmployees();
using DemoBLL;
using DemoDLL;
using System;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBLL employeeBLL = new EmployeeBLL(new EmployeeDLL());

            var employees = employeeBLL.GetEmployees("jo");

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.City}");
            }

            Console.ReadKey();
        }
    }
}

using DemoBLL;
using DemoEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDLL
{
    public class EmployeeDLL : IEmployeeDLL
    {
        public List<Employee> employees = new List<Employee>();

        public EmployeeDLL()
        {
            employees.Add(new Employee { Id = 1, Name = "John", City = "Mumbai" });
            employees.Add(new Employee { Id = 2, Name = "Sam", City = "Newyork" });
            employees.Add(new Employee { Id = 3, Name = "Tim", City = "London" });
            employees.Add(new Employee { Id = 3, Name = "Jonathan", City = "London" });

        }

        public ICollection<Employee> GetEmployees(string name, string city)
        {
            return employees.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}

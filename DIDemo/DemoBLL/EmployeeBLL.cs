using DemoEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoBLL
{
    public class EmployeeBLL
    {
        private readonly IEmployeeDLL _employeeDLL;

        public EmployeeBLL(IEmployeeDLL employeeDLL)
        {
            _employeeDLL = employeeDLL;
        }
        public ICollection<Employee> GetEmployees(string name)
        {
           return _employeeDLL.GetEmployees(name);
        }
    }
}

using DemoEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoBLL
{
    public interface IEmployeeDLL
    {
        ICollection<Employee> GetEmployees(string name);
    }
}

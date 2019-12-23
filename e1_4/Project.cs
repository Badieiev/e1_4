using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_4
{
    class Project
    {
        public string Name { get; set; }
        System.DateTime SDate;
        public Project(string projectName, DateTime startDate)
        {
            projectName = Name;
            startDate = SDate;
        }

        List<Employee> employees = new List<Employee>();


        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}

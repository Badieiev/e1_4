using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_4
{
    class Project
    {
        public string Name { get;}
        public DateTime SDate { get; }
        public Project(string projectName, DateTime startDate)
        {
            Name = projectName;
            SDate = startDate;
        }

        List<Employee> employees = new List<Employee>();


        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public int NumberOfEmployees()
        {
            return employees.Count();
        }

        public bool AreAllEmployeesYounger30()
        {
            foreach (var employee in employees)
            {
                if (employee.Age > 30)
                {
                    return false;
                }
            }
            return true;
        }

        public bool AreAllEmployeesYounger30_2()
        {
            return employees.All(employee => employee.Age <= 30);
        }

        public bool OneEmployee30()
        {
            foreach (var employee in employees)
            {
                if (employee.Age == 30)
                {
                    return true;
                }
            }
            return false;
        }

        public bool OneEmployee30_2()
        {
            return employees.Any(employee => employee.Age == 30);
        }
    }
}

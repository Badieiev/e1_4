using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_4
{
    class Company
    {
        public string Name { get; set; }
        public Company(string companyName)
        {
            companyName = Name;
        }

        List<Employee> employees = new List<Employee>();
        List<Project> projects = new List<Project>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        public List<Employee> GetEmployeesWith2orMoreProject()
        {
            List<Employee> selectedEmployees = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.NumberOfProjects()>=2)
                {
                    selectedEmployees.Add(employee);
                }
            }

            selectedEmployees.Sort();
            return selectedEmployees;
        }

        public List<Employee> GetEmployees2orMoreProject()
        {
            return employees.Where(item => item.NumberOfProjects() >= 2).OrderBy(item => item).ToList();
        }

        public List<Project> GetProjectsWithDate(DateTime dateTime)
        {
            return null;
        }

        public int NumberOfProjects()
        {
            return 0;
        }

        public string GetOldEmployeeName()
        {
            return null;
        }

        public void AssignProject(Employee employee, Project project)
        {
            project.AddEmployee(employee);
            employee.AddProject(project);
        }
    }
}

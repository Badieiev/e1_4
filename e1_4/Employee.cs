using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_4
{
    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string employeeName, int employeeAge)
        {
            Name = employeeName;
            Age = employeeAge;
        }
        public int CompareTo(Employee p)
        {
            return this.Name.CompareTo(p.Name);
        }

        List<Project> projects = new List<Project>();

        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        public int NumberOfProjects()
        {
            return projects.Count;
        }
    }
}

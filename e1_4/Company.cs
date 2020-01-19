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

        public List<Employee> GetEmployees2orMoreProject() //список сотрудников, работающих на двух и более проектах(в алфавитном порядке)
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

        public List<Employee> GetEmployees2orMoreProject_2()
        {
            return employees.Where(employee => employee.NumberOfProjects() >= 2).OrderBy(employee => employee).ToList();
        }

        public List<Project> GetProjectsWithDate(DateTime dateTime) //список проектов, начавшихся после определенной даты(в хронологическом порядке)
        {
            List<Project> selectedProjects = new List<Project>();

            foreach (var project in projects)
            {
                if (project.SDate > dateTime)
                {
                    selectedProjects.Add(project);
                }
            }
            selectedProjects.Sort((x, y) => DateTime.Compare(x.SDate, y.SDate));
            return selectedProjects;
        }

        public int NumberOfNewProjects() //количество проектов, продолжающихся не более года, в которых заняты сотрудники, не старше 30лет
        {
            List<Project> selectedProjects = new List<Project>();

            foreach (var project in projects)
            {
                if ((DateTime.Now - project.SDate).TotalDays < 365 && project.AreAllEmployeesYounger30())
                {
                    selectedProjects.Add(project);
                }
            }
            return selectedProjects.Count;
        }

        public int NumberOfNewProjects_2()
        {
            return projects.Where(project => (DateTime.Now - project.SDate).TotalDays < 365 && project.AreAllEmployeesYounger30()).Count();
        }

        public string GetOldEmployeeName1NewProject() //фамилия самого старшего сотрудника, работающего строго над одним проектом, начавшемся в этом году
        {
            int largest = 0;
            string name = null;
            foreach (var employee in employees)
            {
                if (!employee.OneNewProject())
                {
                    continue;
                }

                if (largest < employee.Age)
                {
                    largest = employee.Age;
                    name = employee.Name;
                }
            }
            return name;
        }

        public string NameOlderEmployee()
        {
            int largest = 0;
            string name = null;
            foreach (var employee in employees)
            {
                if (largest < employee.Age)
                {
                    largest = employee.Age;
                    name = employee.Name;
                }
            }
            return name;
        }

        public string NameOlderEmployee_2()
        {
            var biggest1 = employees.Aggregate((i1, i2) => i1.Age > i2.Age ? i1 : i2);
            return biggest1.Name;
        }

        public string NameOlderEmployee_3()
        {
            var name = (from employee in employees
                        orderby employee.Age descending
                        select employee.Name).First();
            return name;
        }

        public void AssignProject(Employee employee, Project project)
        {
            project.AddEmployee(employee);
            employee.AddProject(project);
        }
    }
}

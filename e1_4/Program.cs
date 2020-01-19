using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e1_4
{
    //Класс Сотрудник- фамилия, возраст, проекты, на которых он работает
    //Класс Проект - название,дата начала работы над  проектом, список сотрудников, работающих над проектом
    //Класс Ит-компания - название, список сотрудников, список проектов
    //Методы, позволяющие получить следующую информацию:
    //    -список сотрудников, работающих на двух и более проектах(в алфавитном порядке)
    //    -список проектов, начавшихся после определенной даты(в хронологическом порядке)
    //    -количество проектов, продолжающихся не более года, в которых заняты сотрудники, не старше 30лет
    //    -фамилия самого старшего сотрудника, работающего строго над одним проектом, начавшемся в этом году
    
    class Program
    {
        static void Main(string[] args)
        {
            Company epam = new Company("Epam");

            Employee vasya = new Employee("Vasya", 29);
            epam.AddEmployee(vasya);
            Employee petro = new Employee("Petro", 27);
            epam.AddEmployee(petro);
            Employee alex = new Employee("Alex", 35);
            epam.AddEmployee(alex);
            Employee ivan = new Employee("Ivan", 25);
            epam.AddEmployee(ivan);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Random r = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                epam.AddEmployee(new Employee("Z", r.Next(20, 40)));
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.Milliseconds);

            Project p1 = new Project("first commit", new DateTime(2008, 5, 1));
            epam.AddProject(p1);
            Project p2 = new Project("second commit", new DateTime(2009, 5, 1));
            epam.AddProject(p2);
            Project p3 = new Project("third commit", new DateTime(2019, 5, 1));
            epam.AddProject(p3);
            Project p4 = new Project("fourth commit", new DateTime(2019, 4, 1));
            epam.AddProject(p4);


            epam.AssignProject(vasya, p1);
            epam.AssignProject(vasya, p2);
            epam.AssignProject(alex, p3);
            epam.AssignProject(ivan, p2);
            epam.AssignProject(ivan, p4);

            var n = epam.GetEmployees2orMoreProject();
            foreach (var item in n)
            {
                Console.WriteLine(item.Name);
            }

            var b = epam.GetProjectsWithDate(new DateTime(2008, 1, 1));
            foreach (var item in b)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(epam.NumberOfNewProjects());

            sw.Restart();
            Console.WriteLine(epam.NameOlderEmployee());
            sw.Stop();
            Console.WriteLine(sw.Elapsed.Milliseconds);

            sw.Restart();
            Console.WriteLine(epam.NameOlderEmployee_2());
            sw.Stop();
            Console.WriteLine(sw.Elapsed.Milliseconds);

            sw.Restart();
            Console.WriteLine(epam.NameOlderEmployee_3());
            sw.Stop();
            Console.WriteLine(sw.Elapsed.Milliseconds);

            Console.WriteLine(epam.GetOldEmployeeName1NewProject());

            Console.ReadKey();
        }
    }
}

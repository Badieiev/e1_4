using System;
using System.Collections.Generic;
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

            Project p1 = new Project("first commit", new DateTime(2008, 5, 1));
            epam.AddProject(p1);
            Project p2 = new Project("second commit", new DateTime(2009, 5, 1));
            epam.AddProject(p2);

            epam.AssignProject(vasya, p1);
            epam.AssignProject(vasya, p2);

            var n = epam.GetEmployeesWith2orMoreProject();
            foreach (var item in n)
            {
                Console.WriteLine(item.Name);
            }
            var m = epam.GetEmployees2orMoreProject();
            foreach (var item in m)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}

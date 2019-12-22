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

    class Employee
    {
        public string Name { get; set; }
        public int Old { get; set; }
        public Employee(string name, int old)
        {
            name = Name;
            old = Old;
        }
    }

    class Project
    {
        public string Name { get; set; }

        public Project(string name)
        {
            name = Name;
        }
    }

    class Company
    {
        public string Name { get; set; }
        public Company(string name)
        {
            name = Name;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
        
        }
    }
}

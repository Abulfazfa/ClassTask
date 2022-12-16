using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }



        public void ShowPersonsInfo(Predicate<int> person)
        {
            Person person1 = new Person();
            person1.Name = "A";
            person1.Surname = "AA";
            person1.Address = "AAA";
            person1.Salary = 1100;

            Person person2 = new Person();
            person2.Name = "B";
            person2.Surname = "BB";
            person2.Address = "BBB";
            person2.Salary = 1200;

            Person person3 = new Person();
            person3.Name = "C";
            person3.Surname = "CC";
            person3.Address = "CCC";
            person3.Salary = 1300;

            List<Person> list = new List<Person>();
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            foreach (var item in list)
            {
                if (person(item.Salary))
                {
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Address}");
                }
            }
        }
    }
}

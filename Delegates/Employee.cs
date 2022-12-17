using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    internal class Employee
    {
        public int Age { get; set; }
        public int Salary { get; set; }
        public int Count { get; set; }

        public void ShowEmployeeInfo(Predicate<int>employee)
        {
            Employee employee1 = new Employee();
            employee1.Age = 26;
            employee1.Salary = 1100;
            employee1.Count = 10;
            Employee employee2 = new Employee();
            employee2.Age = 28;
            employee2.Salary = 900;
            employee2.Count = 9;
            Employee employee3 = new Employee();
            employee3.Age = 48;
            employee3.Salary = 1300;
            employee3.Count = 14;

            List<Employee> list = new List<Employee>();
            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);

            double sum = 0;
            double count = 0;
            foreach (var item in list)
            {
                if (employee(item.Age))
                {
                    sum += item.Salary;
                    count += item.Count;
                   
                }
            }
            Console.WriteLine(sum/count);
        }
    }
}

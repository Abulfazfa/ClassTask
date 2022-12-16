using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Person person = new Person();

            //Predicate<int> personSalary = s => s > 1000;
            //person.ShowPersonsInfo(personSalary);


            //Book book = new Book();

            //Predicate<string> authorBook = b => b == "Nizami";
            //book.ShowBookInfo(authorBook);
            

            Employee employee = new Employee();
            Predicate<int> employeeSalary = s => s > 1000;
            employee.ShowEmployeeInfo(employeeSalary);
        }
        
        
    }
}

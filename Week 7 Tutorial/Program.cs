using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_7_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee() { name = "Jane", id = 1, gender = Gender.Female },
                new Employee() { name = "James", id = 2, gender = Gender.Male },
                new Employee() { name = "Kim", id = 3, gender = Gender.Male },
                new Employee() { name = "Kitty", id = 4, gender = Gender.Female }
            };
            DisplayEmployeeList(employees);
            DisplayEmployeeList(FilterByGender(employees, Gender.Male));
        }

        static void DisplayEmployeeList(List<Employee> staff)
        {
            foreach (Employee e0 in staff)
            {
                Console.WriteLine(e0.ToString()); 
            }
            Console.WriteLine("the end.");
        }

        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            List<Employee> filteredList = staff.Where(staff => staff.gender == gender).ToList();            
            return filteredList;
        }
    }
}

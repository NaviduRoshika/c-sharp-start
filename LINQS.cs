using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace my_csharp
{
    public class LINQS
    {
        
    }
    [Serializable()]
    public class Employee
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private decimal salary;
        private int age;
        private List<int> appraisal;

        public int EmployeeId
        {
            get => employeeID;
            set => employeeID = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        [XmlIgnore]
        public List<int> Appraisal
        {
            get => appraisal;
            set => appraisal = value;
        }

        public static List<Employee> SortEmployees(List<Employee> employee)
        {
            var list = from emp in employee
                orderby emp.Age
                select emp;
            return list.ToList();
        }

        public static void DisplayQueryData(List<Employee> employee,string query)
        {
            int result = employee.Count;
            Console.WriteLine("Found ({0}) Employees",result);
            if (query != null)
            {
                Console.WriteLine(query);
            }

            for (int i = 0; i < result; i++)
            {
                Console.Write($"{i+1}) {employee[i].FirstName} {employee[i].LastName},{employee[i].Salary},{employee[i].Age},last 5 appariasals |");
                foreach (var apps in employee[i].Appraisal)
                {
                    Console.Write("{0}|",apps);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void DisplayQueryData(List<Employee> employee)
        {
            DisplayQueryData(employee,null);
        }
    }
}
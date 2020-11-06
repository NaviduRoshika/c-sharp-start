using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace my_csharp
{
    public class SerialiZation
    {
        public static void MainX(string[] args)
        {
            string xmlText = string.Empty;
            var listOfEmployees = new List<Employee>
            {
                new Employee{EmployeeId=1100,FirstName = "Nave",LastName = "Zone",Salary = 3300m,Age = 35,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1101,FirstName = "Nave1",LastName = "Zone",Salary = 5001m,Age = 14,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1102,FirstName = "Nave2",LastName = "Zone",Salary = 5002m,Age = 35,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1103,FirstName = "Nave3",LastName = "Zone",Salary = 5003m,Age = 40,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1104,FirstName = "Nave4",LastName = "Zone",Salary = 5004m,Age = 12,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1105,FirstName = "Nave5",LastName = "Zone",Salary = 1000m,Age = 32,Appraisal = new List<int>{7,7,8,9}},
                new Employee{EmployeeId=1106,FirstName = "Nave6",LastName = "Zone",Salary = 1000m,Age = 20,Appraisal = new List<int>{7,7,8,9}}
            };
            
            XmlSerializer xmlWriter = new XmlSerializer(typeof(List<Employee>));
            using (StringWriter sw = new StringWriter())
            {
                xmlWriter.Serialize(sw,listOfEmployees);
                Console.WriteLine(sw.ToString());
                xmlText = sw.ToString();
                Console.WriteLine(xmlText);
            }
            XmlSerializer xmlReader = new XmlSerializer(typeof(List<Employee>));
            using (StringReader sr = new StringReader(xmlText))
            {
                List<Employee> list = (List<Employee>)(xmlReader.Deserialize(sr));
                foreach (var emp in list)
                {
                    Console.WriteLine(emp.FirstName);
                    Console.WriteLine(emp.LastName);
                    Console.WriteLine("----------------");
                }
            }
            
        }
    }
}
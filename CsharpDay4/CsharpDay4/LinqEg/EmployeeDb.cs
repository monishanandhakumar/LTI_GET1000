using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    class Employee
    {
       public int id { get; set; }
        public string name { get; set; }
        public int age { set; get; }
        public string gender { get; set; }
        public string city { get; set; }

       public Employee(int id,string name,int age,string gender,string city)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.city = city;

        }

    
    class EmployeeDb
    {
        static void Main()
        {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee(1, "gaya", 23, "female", "chennai"));
                employees.Add(new Employee(2, "sri", 24, "male", "chennai"));
                employees.Add(new Employee(3, "mathu", 26, "female", "salem"));
                employees.Add(new Employee(4, "Lavanya", 22, "female", "salem"));
                employees.Add(new Employee(1, "Hari", 27, "male", "maduari"));

                //display the employee from chennai

                var emp = from e in employees
                          where e.city.Equals("chennai")
                          select e;
                foreach (var ep in emp)
                {

                    Console.WriteLine(ep.id + " " + ep.name + " " + ep.age + " " + ep.gender);
                }
                //Method syntax or lambda expression
                var employeedata = employees.Where(empl => empl.age>23);

                Console.WriteLine("display the emplyee age >23");
                foreach (var ep in employeedata)
                {
                    
                    Console.WriteLine(ep.id + " " + ep.name + " " + ep.age + " " + ep.gender);
                }
                //display name,city 
                var emp1 = from e in employees
                           where e.city.Equals("chennai")
                           select new { empname = e.name, empcity = e.city };
                Console.WriteLine("display name and city emplyee from chennai");
                foreach (var ep in emp1)
                {
                    
                    Console.WriteLine(ep.empname + " " + ep.empcity);
                }
                //display the employee details orderby gender
                IEnumerable<Employee> emp2 = from e in employees
                                             where e.age > 23
                                             orderby e.gender,e.name
                                             select e;
                Console.WriteLine("display the employee details orderby gender");
                foreach (var ep in emp2)
                {
                    
                    Console.WriteLine(ep.id + " " + ep.name + " " + ep.age + " " + ep.gender);
                }

                var result = employees.Where(emp => emp.age > 23).OrderBy(emp => emp.gender);
                Console.WriteLine("Using Lambda expression");
                foreach (var ep in result)
                {

                    Console.WriteLine(ep.id + " " + ep.name + " " + ep.age + " " + ep.gender);
                }
                //Group by
                //No of males and females
                var gendercount = from e in employees
                                  group e by e.gender;

                Console.WriteLine("No of males and females");
                foreach(var g in gendercount)
                {
                    Console.WriteLine(g.Key+" "+g.Count());
                }
                //Lambda expression
                var groupgender = employees.GroupBy(emp => emp.gender);
                Console.WriteLine("Method Syntax");
                foreach (var g in groupgender)
                {
                    Console.WriteLine(g.Key+" "+g.Count());
                }

            }
        }
    }
}

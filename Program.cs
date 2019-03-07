using System;
using System.Collections.Generic;

namespace listEmployees
{
    public class Company
    {
        public string Name {get;}
        public DateTime CreatedOn {get;}
        public List<Employee> CurrentEmployees { get; set; }

        public Company(string name, DateTime createdOn) {
            Name = name;
            CreatedOn = createdOn;
        }
    }
    public class Employee
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Title {get; set;}
        public DateTime StartDate {get;set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company FroMo = new Company("FroMo", DateTime.Now);

            Employee jimbo = new Employee()
            {
                FirstName = "Jimbo",
                LastName = "Gimbo",
                Title = "Sales Marketeer",
                StartDate = DateTime.Now

            };
            Employee julia = new Employee()
            {
                FirstName = "Julia",
                LastName = "Gulia",
                Title = "Boss Person",
                StartDate = DateTime.Now

            };
            Employee hernando = new Employee()
            {
                FirstName = "Hernando",
                LastName = "ElBrando",
                Title = "Hitman",
                StartDate = DateTime.Now

            };

            FroMo.CurrentEmployees.Add(hernando);
            FroMo.CurrentEmployees.Add(julia);
            FroMo.CurrentEmployees.Add(jimbo);




        }
    }
}

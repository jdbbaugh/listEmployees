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
            CurrentEmployees = new List<Employee>();
        }
        public void ListEmployees () {
            foreach(Employee worker in CurrentEmployees) {
                Console.WriteLine($"{worker.FirstName} {worker.LastName} started on {worker.StartDate} and is the {worker.Title} at {Name}");
            }
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
            Company FroMo = new Company("FroMo", new DateTime (20190101));

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
                StartDate = new DateTime(2008, 3, 1, 7, 0, 0)

            };
            Employee hernando = new Employee()
            {
                FirstName = "Hernando",
                LastName = "ElBrando",
                Title = "Hitman",
                StartDate = new DateTime(2017, 6, 11, 9, 0, 0)

            };

            FroMo.CurrentEmployees.Add(jimbo);
            FroMo.CurrentEmployees.Add(julia);
            FroMo.CurrentEmployees.Add(hernando);

            FroMo.ListEmployees();

        }
    }
}

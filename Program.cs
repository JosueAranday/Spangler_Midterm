using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;

namespace Spangler_Midterm
{
    public class Employee
    {
        //Fields
        private string firstName;
        private string lastName;
        private string workID;
        private int yearStartedWked;
        private double initSalary;
        protected double curSalary;

        //Constructor
        public Employee(string firstName, string lastName, string workID,
                        int yearStartedWked, double initSalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.workID = workID;
            this.yearStartedWked = yearStartedWked;
            this.initSalary = initSalary;
        }

        //Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string WorkID
        {
            get { return workID; }
            set { workID = value; }
        }
        public int YearStartedWked
        {
            get { return yearStartedWked; }
            set { yearStartedWked = value; }
        }
        public double InitSalary
        {
            get { return initSalary; }
            set { initSalary = value; }
        }
        //No set for read-only variable
        public double CurSalary
        {
            get { return curSalary; }
        }

        //Function to calculate current salary and assign curSalary to initSalary
        public virtual void calcCurSalary(int currentYear)
        {
            curSalary = initSalary;
        }
    }

    public class Worker : Employee
    {
        //Class field
        private int yearWorked;

        //Class constructors
        public Worker(string firstName, string lastName, string workID,
                      int yearStartedWked, double initSalary)
            : base(firstName, lastName, workID, yearStartedWked, initSalary)
        {
            yearWorked = 0;
        }

        //Class property
        public int YearWorked
        {
            get { return yearWorked; }
            set { yearWorked = value;  }
        }

        //Function to calculate how many years an employee has worked
        public void calcYearWorked(int currentYear)
        {
            yearWorked = currentYear - YearStartedWked;
        }

        //Function to calculate a worker's salary with yearly increments
        public override void calcCurSalary(int currentYear)
        {
            for (int i = 0; i < yearWorked; i++)
            {
                InitSalary *= 1.03;
            }

            curSalary = InitSalary;
        }
    }

    public class Manager : Worker
    {
        //Class field
        private int yearPromo;

        //Class constructor
        public Manager(string firstName, string lastName, string workID,
                  int yearStartedWked, double initSalary, int yearWorked, int yearPromo)
        : base(firstName, lastName, workID, yearStartedWked, initSalary)
        {
            this.yearPromo = yearPromo;
        }

        //Class property
        public int YearPromo
        {
            get { return yearPromo; }
            set { yearPromo = value; }
        }

        //Function to calculate a manager's salary with yearly increments and a bonus
        //Different increments are accounted for based on employee position during given years
        public override void calcCurSalary(int currentYear)
        {
            //Calculating separately the amount of years spent as a worker and a manager
            int yearsWorker = yearPromo - YearStartedWked;
            int yearsManager = YearWorked - yearsWorker;

            for (int i = 0; i < yearsWorker; i++)
            {
                InitSalary *= 1.03;
            }

            double workerSalary = InitSalary;

            for (int i = 1; i <= yearsManager; i++)
            {
                workerSalary *= 1.05;
            }

            double managerSalary = workerSalary;

            managerSalary *= 1.1;

            curSalary = managerSalary;
        }
    }

    public class EmployeeDemo
    {
        public static void Main(string[] args)
        {
            //Call readData function
            Employee[] employees = readData();

            //Call objSort function
            objSort(employees);

            //Get user input for range of current salary
            Console.WriteLine("Enter the minimum current salary: ");
            double minSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the maximum current salary: ");
            double maxSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Employees found in this range: ");

            //Display employees that fall in the requested range
            foreach (Employee e in employees)
            {
                if (e.curSalary >= minSalary && e.curSalary <= maxSalary)
                {
                    Console.WriteLine();
                }  
            }
        }

        public static readData()
        {
            //Read and save data from the text files dynamic arrays
            //Worker data
            StreamReader workerData = new StreamReader("worker.txt");
            int workerNum = Convert.ToInt32(workerData.ReadLine());
            Worker[] workers = new Worker[workerNum];

            for (int i = 0; i < workerNum; i++)
            {

            }

            //Manager data
            StreamReader managerData = new StreamReader("manager.txt");
            int managerNum = Convert.ToInt32(managerData.ReadLine());
            Manager[] managers = new Manager[managerNum];

            for (int i = 0; i < managerNum; i++)
            {

            }

            //Get user input for the current year
            Console.WriteLine("Enter the current year: ");
            int currentYear = Convert.ToInt32(Console.ReadLine());

            return;
        }

        public static void objSort(Employee[] employees)
        {
            //Sorts the array by salary in descending order
            for (int i = 0; i < employees.Length; i++)
            {

            }


        }

    }
}

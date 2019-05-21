//Lara Corkery 
//Test 2 22/05/2019 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Assignment
{
     public class Program
    {
        public static void Main(string[] args)
        {


            

            Console.WriteLine("Please Enter The Number Of Hours Worked: ");
            int numHours = int.Parse(Console.ReadLine());


        }
    }
    class Salary
    {
        public double annualSalary { get; set; } = 80000;
        public double weeklySalary { get; set; }
        

        //The public constructor 
        public Salary(double annualSalary, double weeklySalary)
        {
            Salary s1 = new Salary(DisplaySalary);
            Console.WriteLine("Your Annual Income Per Year is $" + annualSalary);
            Console.WriteLine("You Weekly Salary Has Calculated To : $" + Math.Round(s1.DisplaySalary), 2)

        }

        static double DisplaySalary()
        {
            return weeklySalary + (1000 / 1);


        }
    }
       
   class Wages
    {
        private double hourlyRate;
        private double weeklyWages;
        private int numHours;

        public double HourlyRates { get; set; } = 33.72; //The value of Hourly Rates
        public double WeeklyWages { get; set; }

        public Wages(double hourlyRates, double weeklyWages)
        {
            
        }
    } */


}

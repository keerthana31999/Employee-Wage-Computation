using System;

namespace Employee_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculation of employee computation");
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 2:
                    empHrs = 4;
                    break;
                case 1:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage :" + empWage);
        }
    }
}

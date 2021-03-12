using System;

namespace Employee_Computation
{
    class Program
    {
        static void Main(String[] args)
        {


            Empwage Microsoft =new Empwage("Microsoft", 40, 5, 10);
            Empwage Wipro = new Empwage("Wipro", 10, 4, 20);
            Microsoft.computeEmpWage();
            Wipro.computeEmpWage();
            Console.WriteLine(Microsoft.toString());
            Console.WriteLine(Wipro.toString());
        }



    }
    }
}




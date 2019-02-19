using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {

                Console.WriteLine("the first number its bigger");
            }

        else
            {
                Console.WriteLine("the second number its bigger");
            
            }
        }
    }
}

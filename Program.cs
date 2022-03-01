using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = 10;
            num2 = 20;
            num3 = 30;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is largest");
                }
                else
                {
                    Console.WriteLine("num3 is largest");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("num2 is largest");
            else
                Console.WriteLine("num3 is largest");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int goodNum1 = 0;
            int goodNum2 = 0;
            var num1 = Console.ReadLine();
            if (num1 == "")
            {
                Console.WriteLine("Hi User please Enter a Value Again");
                return;
            }
            else
            {
                goodNum1 = Convert.ToInt32(num1);
            }
            var num2 = Console.ReadLine();
            if (num2 == "")
            {
                Console.WriteLine("Hi User please Enter a Value Again");
                return;
            }
            else
            {
                goodNum2 = Convert.ToInt32(num2);
            }
            var res = goodNum1 + goodNum2;
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

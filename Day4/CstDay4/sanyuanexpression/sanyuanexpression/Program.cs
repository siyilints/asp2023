using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanyuanexpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input one number:___");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input second number:___");
            int a2 = Convert.ToInt32(Console.ReadLine());

            int max = a1 > a2 ? a1 : a2;
            Console.WriteLine("the max number between {0} and {1} is {2}", a1, a2, max);
        }
    }
}

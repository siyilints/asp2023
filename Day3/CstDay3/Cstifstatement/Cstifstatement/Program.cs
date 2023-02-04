using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstifstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter one integer number");
            int nums = Convert.ToInt32(Console.ReadLine());

            if (nums % 2 == 0)
            {
                Console.WriteLine("The number : {0} you input is even", nums);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("the number : {0} you input is odd", nums);
                Console.ReadLine();
            }
        }
    }
}

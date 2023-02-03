using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //SayHello();

            //void SayHello()
            //{
            //  Console.WriteLine("Welcome to CST College.!!");

            //  Console.ReadKey();}

            string mystr = "Tom";
            string resultstr;
            resultstr = SayHello(mystr);
            Console.WriteLine(resultstr);
            Console.ReadLine();

            string SayHello(string str)
            {
                string message = "Welcome to CST College:" + str;
                return message;


            }


        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstSwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Print out student mark according
             * Score
             */

            Console.WriteLine("please input student's score (integer between 0~100)");

            int points = Convert.ToInt32(Console.ReadLine());
            #region
            // start switch
            switch (points / 10)
            {
                case 10:
                    Console.WriteLine("great");
                    break;
                case 9:
                    Console.WriteLine("perfect");
                    break;
                case 8:
                    Console.WriteLine("good");
                    break;
                case 7:
                    Console.WriteLine("pass");
                    break;
                case 6:
                    Console.WriteLine("pass");
                    break;
                default:
                    Console.WriteLine("failed");
                    break;
            }
            // end switch
            #endregion


        }
    }
}

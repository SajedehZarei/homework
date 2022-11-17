using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine("pow2 of {0} is : [1}" , input, Pow2(number));
            Console.WriteLine("pow3 of {0} is : [1}" , input, Pow3(number));
        }

        private static double Pow2 (int num)
        {
            return Math.Pow(num,2);
        }
        private static double Pow3 (int num)
        {
            return Math.Pow(num,3);
            
        }
    }
}
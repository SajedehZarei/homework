using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
        string a= Console.ReadLine();
        string b= Console.ReadLine();
        string c= Console.ReadLine();
        int x= Convert.ToInt32(a);
        int y = Convert.ToInt32(b);
        int z = Convert.ToInt32(c);
        if(x+y > z && x+z > y && y+z > x)
        {
            mohit(x,y,z);
        }
        else
        {
           Console.WriteLine("No");
        }
        }

        private static void mohit (int n, int m, int w)
        {
        int outt = n + m + w;
        Console.WriteLine( outt );
        }
    }
}
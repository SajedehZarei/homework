using system;
using system.Collections.Generic;
using system.Text.RegularExpressions;
using system.linq;
namespace Rextester
{
    public class triangle
    {
     public static void Main (string[] args)   
     {
       Console.ReadLine(int x , int y);
       int a = Console.ToInt32(x);
       int b = Console.ToInt32(y);
       int c = Math.Abs(a-b);
       int z = Pow(c,Math.Abs(y));
       Console.ReadLine(z);
     }
    }
}
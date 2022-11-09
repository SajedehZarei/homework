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
        string a= Console.Readline();
        string b= Console.Readline();
        string c= Console.Readline();
        int x= Convert.ToInt32(a);
        int y= Convert.ToInt32(b);
        int z= Convert.ToInt32(c);
        if(x+y>z && x+z>y && y+z>x)
        {
            mohit(x,y,z);
        }
        else
        {
           Console.WriteLine("No");
        }
     }
     private mohit (int n, int m, int w)
     {
        int out= n + m + w;
        Console.WriteLine(out);
     }
     }
    
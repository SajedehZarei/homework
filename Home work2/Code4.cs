using system;
class test()
{
    public static void main()
    {
        string num1=console.ReadLine();
        string num2=console.ReadLine();
        string num3=console.ReadLine();
        int a=convert.ToInt32(num1);
        int b=convert.ToInt32(num2);
        int c=convert.ToInt32(num3);
        console.WriteLine(Calc(a,b,c));
    }
    private static string Calc (int a ,int  b ,int c)
    {
       double delta= (b*b)-(4*a*c);
       double delta1 = Math.sqrt(delta);
       double x1 = ((-b + delta1)/(2*a));
       double x2 = ((-b - delta1)/(2*a));
       return convert.ToString("x1 is:"+x1+ "and x2 is :" +x2);
    }
    
}
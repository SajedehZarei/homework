using system;
class test()
{
    public static void main(string[] args)
    {
        int num1=int.parse(console.ReadLine());
        int num2=int.parse(console.ReadLine());
        int kmm= KMM(num1 , num2);
        int bmm= BMM(num1 , num2);
        console.WriteLine("for number {0} and {1}" , num1 , num2);
        console.WriteLine("KMM is {0}" ,kmm);
        console.WriteLine("BMM is {0}" ,bmm);
        
    }
    private static int KMM(int num1 ,int num2)
    {
        bool flag = false;
        int i=0;
        int kmm=0;
        while(flag==false)
        {
            kmm=num1*i;
            if(kmm % num2 == 0)
            flag = true;
            i++;
        }
        return kmm;
    }
    private static int BMM(int num1 ,int num2)
    {
        while(num2 !=0)
        {
            int c=num1%num2;
            if(c==0)
            return num2;
            else
                num1= num2;
                num2 = c ;
        }
        return num2;
    }
    
}
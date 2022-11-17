using system;
class test()
{
    public static void main()
    {
        int year=0;
        bool flaq=true;
        string mojodi=console.ReadLine();
        string bahre=console.ReadLine();
        string mablaq=console.ReadLine();
        float mojodi1=convert.ToInt32(mojodi);
        float bahare1=convert.ToInt32(bahre);
        float mablaq1=convert.ToInt32(mablaq);
        if(mojodi1 <= mablaq1)
        {
            console.WriteLine(" ERROR : Mojodi is >= mablaq");
            console.ReadKey();
        }
        while (flaq==true)
        {
          mojodi1= mojodi1+(mojodi1*bahre1);
          year++
        if(mojodi1 >= mablaq1)
        {
          flaq = false;
        }
        }
        console.WriteLine("after {0} years , your mojodi will be {1} " , year , mablaq1);
    }
    
}
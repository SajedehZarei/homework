using system;
class test()
{
    public static void main()
    {
        string input = console.ReadLine();
        int age = convert.ToInt32(input);
        int temp = age;
        int year=0;
        int monuth=0;
        int week=0;
        int day=0;
        for(;age >= 365 ; year++)
        {
          age = age - 365 ;
        }
        
        for(; age >= 30 ; monuth++)
        {
            age = age - 30 ;
        }
        for( ; age >= 7 ; week++)
        {
            age = age - 7 ;
        }
        
       console.WriteLine("{0} is : {1} year , {2} mounth , {3} week , {4} day " input ,year , monuth ,week ,age);
     }
    

}
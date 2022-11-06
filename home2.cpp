#include <iostream>
using namespace std ;
int main()
{
    int counter = 0 ;
    int array[100];
    int x , y ;
    cout << "tedad array :" ;
    cin >> x ;
    for (int i = 0 ; i < x ; i++)
    {
        cout << "array :" ;
        cin >> array[i];
    }
    cout << "enter your num :" ;
    cin >> y ;
    for (int i = 0 ; i < x ; i++)
    {
        if (array[i] == y)
        {
            counter++ ;
        }
    }
     cout << "array :" << counter ;
return 0 ;
}
#include <iostream>
using namespace std;

int main() 
{
    bool isMan;
    int age;

    cin >> isMan >> age;

    if(isMan == 0)
    {
        if(age >= 19)
        {
            cout << "MAN";
        }
        else
        {
            cout << "BOY";
        }
    }
    else
    {
        if(age >= 19)
        {
            cout << "WOMAN";
        }
        else
        {
            cout << "GIRL";
        }
    }

    return 0;
}
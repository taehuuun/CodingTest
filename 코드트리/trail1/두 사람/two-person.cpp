#include <iostream>
using namespace std;

int main() 
{
    int firstAge, secAge;
    char firstGender, secGender;

    cin >> firstAge >> firstGender;
    cin >> secAge >> secGender;

    if(firstAge >= 19 && firstGender == 'M' || secAge >= 19 && secGender == 'M')
    {
        cout << "1";
    }
    else
    {
        cout << "0";
    }

    return 0;
}
#include <iostream>
using namespace std;

int main() 
{
    int aMath, aEng, bMath, bEng;

    cin >> aMath >> aEng >> bMath >> bEng;

    if(aMath == bMath)
    {
        if(aEng > bEng)
        {
            cout << "A";
        }
        else if(bEng > aEng)
        {
            cout << "B";
        }
    }
    else
    {
        if(aMath > bMath)
        {
            cout << "A";
        }
        else if(bMath > aMath)
        {
            cout << "B";
        }
    }

    return 0;
}
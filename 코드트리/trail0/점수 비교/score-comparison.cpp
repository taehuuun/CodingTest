#include <iostream>
using namespace std;

int main() 
{
    int aMath, aEng;
    int bMath, bEng;

    cin >> aMath >> aEng >> bMath >> bEng;

    if(aMath > bMath && aEng > bEng)
    {
        cout << "1";
    }
    else
    {
        cout << "0";
    }

    return 0;
}
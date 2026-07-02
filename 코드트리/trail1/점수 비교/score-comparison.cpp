#include <iostream>
using namespace std;

int main() 
{
    int aMath, aEng;
    int bMath, bEng;

    cin >> aMath >> aEng;
    cin >> bMath >> bEng;

    cout << (aMath > bMath && aEng > bEng);

    return 0;
}
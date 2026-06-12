#include <iostream>
using namespace std;

int main() 
{
    const float FEET = 30.48;
    const int MILE = 160934;

    cout << fixed;
    cout.precision(1);

    cout << "9.2ft = " << 9.2 * FEET << "cm" << endl;
    cout << "1.3mi = " << 1.3 * MILE << "cm";

    return 0;
}
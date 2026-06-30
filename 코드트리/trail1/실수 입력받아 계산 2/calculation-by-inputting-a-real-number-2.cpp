#include <iostream>
using namespace std;

int main() 
{
    float a;

    cin >> a;

    cout << fixed;
    cout.precision(2);

    cout << a + 1.5f;

    return 0;
}
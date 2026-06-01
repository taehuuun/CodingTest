#include <iostream>
using namespace std;

int main() 
{
    int a = 13;
    float b = 0.165000;

    cout << fixed;
    cin.precision(6);

    cout << a << " * " << b <<" = " << a*b;

    return 0;
}
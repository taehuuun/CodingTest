#include <iostream>
using namespace std;

int main() 
{
    float a = 5.26f;
    float b = 8.27f;

    cout << fixed;
    cout.precision(3);

    cout << a * b;

    return 0;
}
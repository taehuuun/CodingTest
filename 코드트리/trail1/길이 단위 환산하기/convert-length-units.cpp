#include <iostream>
using namespace std;

int main() 
{
    const float FT = 30.48f;

    float input;

    cin >> input;

    cout << fixed;
    cout.precision(1);

    cout << input * FT;

    return 0;
}
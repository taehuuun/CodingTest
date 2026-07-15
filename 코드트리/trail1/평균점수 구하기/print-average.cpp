#include <iostream>
using namespace std;

int main() 
{
    float input = 0, sum = 0;

    for(int i = 0; i < 8; i++)
    {
        cin >> input;
        sum += input;
    }

    cout << fixed;
    cout.precision(1);

    cout << sum / 8;

    return 0;
}
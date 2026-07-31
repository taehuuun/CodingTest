#include <iostream>
using namespace std;

void Calculate(int *a, int *b)
{
    if(*a > *b)
    {
        *b += 10;
        *a *= 2;
    }
    else
    {
        *b *= 2;
        *a += 10;
    }
}

int main() 
{
    int a, b;

    cin >> a >> b;

    Calculate(&a, &b);

    cout << a << ' ' << b;

    return 0;
}
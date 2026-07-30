#include <iostream>
using namespace std;

void OperatinNumber(int *a, int *b)
{
    if(*a > *b)
    {
        *a += 25;
        *b *= 2;
    }
    else
    {
        *a *= 2;
        *b += 25;
    }
}

int main() 
{
    int a, b;

    cin >> a >> b;

    OperatinNumber(&a, &b);

    cout << a << " "<< b;

    return 0;
}
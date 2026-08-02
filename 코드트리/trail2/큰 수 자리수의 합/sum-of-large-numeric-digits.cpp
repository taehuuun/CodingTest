#include <iostream>
using namespace std;

int Func(int n)
{
    if(n < 10)
    {
        return n;
    }

    return Func(n/10) + n % 10;
}

int main() 
{
    int a,b,c;

    cin >> a >> b >> c;

    cout << Func(a * b * c);

    return 0;
}
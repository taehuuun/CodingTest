#include <iostream>
using namespace std;

int Function(int n)
{
    if(n < 10)
    {
        return n * n;
    }

    return Function(n/10) + (n % 10) * (n % 10);
}

int main() 
{
    int n;

    cin >> n;

    cout << Function(n);

    return 0;
}
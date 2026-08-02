#include <iostream>
using namespace std;

int count = 0;

int Function(int n)
{
    if(n == 1)
    {
        return count;
    }

    count++;

    if(n % 2 == 0)
    {
        return Function(n / 2);
    }
    else
    {
        return Function(n / 3);
    }
}

int main() 
{
    int n;

    cin >> n;

    cout << Function(n);

    return 0;
}
#include <iostream>
using namespace std;

bool IsPrimeNumber(int n)
{
    for(int i = 2; i < n; i++)
    {
        if(n % i == 0)
        {
            return false;
        }
    }

    return true;
}

int GetPrimeNumberSum(int a, int b)
{
    int sum = 0;

    for(int i = a; i <= b ; i++)
    {
        if(IsPrimeNumber(i))
        {
            sum += i;
        }
    }

    return sum;
}

int main() 
{
    int a, b;
    
    cin >> a >> b;

    cout << GetPrimeNumberSum(a, b);

    return 0;
}
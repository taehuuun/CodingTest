#include <iostream>
using namespace std;

bool IsSumEven(int n)
{
    int sum = 0;
    while(n != 0)
    {
        sum += n % 10;
        n /= 10;
    }

    return sum % 2 == 0;
}

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

int GetFindNumCount(int a, int b)
{
    int count = 0;

    for(int i = a; i <= b; i++)
    {
        if(IsPrimeNumber(i) && IsSumEven(i))
        {
            count++;
        }
    }

    return count;
}

int main() 
{
    int a, b;

    cin >> a >> b;

    cout << GetFindNumCount(a, b);

    return 0;
}
#include <iostream>
using namespace std;

int count = 0;

int Func(int n, int count)
{
    if(n == 1)
    {
        return count;
    }

    count++;

    return n % 2 == 0 ? Func(n/2, count): Func(n * 3 + 1, count);
}

int main() 
{
    int n;

    cin >> n;

    cout << Func(n, 0);

    return 0;
}
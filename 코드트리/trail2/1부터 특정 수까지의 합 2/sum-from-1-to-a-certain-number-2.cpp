#include <iostream>
using namespace std;

int Sum(int n)
{
    if(n == 0)
    {
        return 0;
    }

    return Sum(n - 1) + n;
}

int main() 
{
    int n;

    cin >> n;

    cout << Sum(n);

    return 0;
}
#include <iostream>
using namespace std;

int main() 
{
    int n, sum = 0;

    cin >> n;

    for(int i = n; i <= 100; i++)
    {
        sum += i;
    }

    cout << sum;

    return 0;
}
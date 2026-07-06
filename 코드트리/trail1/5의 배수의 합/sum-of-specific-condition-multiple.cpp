#include <iostream>
using namespace std;

int main() 
{
    int a, b, sum = 0;

    cin >> a >> b;

    for(int i = (a < b ? a : b); i <= (a > b ? a : b); i++)
    {
        if(i % 5 == 0)
        {
            sum += i;
        }
    }

    cout << sum;

    return 0;
}
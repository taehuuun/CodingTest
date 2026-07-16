#include <iostream>
using namespace std;

int main() 
{
    int a, b, sum = 0, countArr[10] = { };

    cin >> a >> b;

    while(a > 1)
    {
        countArr[a % b]++;
        a /= b;
    }

    for(int i = 0; i < 10; i++)
    {
        int current = countArr[i];

        sum += current * current;
    }

    cout << sum;

    return 0;
}
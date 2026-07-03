#include <iostream>
using namespace std;

int main() 
{
    int a, b, c;
    int max = -999;

    cin >> a >> b >> c;

    if(max < a)
    {
        max = a;
    }

    if(max < b)
    {
        max = b;
    }

    if(max < c)
    {
        max = c;
    }

    cout << max;

    return 0;
}
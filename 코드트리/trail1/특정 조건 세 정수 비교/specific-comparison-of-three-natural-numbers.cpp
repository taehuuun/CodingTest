#include <iostream>
using namespace std;

int main() 
{
    int a, b, c;

    int min = 999;

    cin >> a >> b >> c;

    if(a < min)
    {
        min = a;
    }

    if(b < min)
    {
        min = b;
    }

    if(c < min)
    {
        min = c;
    }

    cout << (a == min) << " " << (a == b && b == c);

    return 0;
}
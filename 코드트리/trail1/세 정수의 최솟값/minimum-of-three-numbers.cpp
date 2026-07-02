#include <iostream>
using namespace std;

int main() 
{
    int a, b, c;
    int min = 9999;

    cin >> a;
    if(a < min)
    {
        min = a;
    }

    cin >> b;
    if(b < min)
    {
        min = b;
    }

    cin >> c;
    if(c < min)
    {
        min = c;
    }

    cout << min;

    return 0;
}
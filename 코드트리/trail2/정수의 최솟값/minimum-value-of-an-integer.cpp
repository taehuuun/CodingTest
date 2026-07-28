#include <iostream>
#include <climits>

using namespace std;

int min(int a, int b, int c)
{
    int min = INT_MAX;
    if(min > a)
    {
        min = a;
    }

    if(min > b)
    {
        min = b;
    }

    if(min > c)
    {
        min = c;
    }

    return min;
}

int main() 
{
    int a, b, c;

    cin >> a >> b >> c;

    cout << min (a,b,c);

    return 0;
}
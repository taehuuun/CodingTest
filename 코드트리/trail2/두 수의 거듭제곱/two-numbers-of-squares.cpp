#include <iostream>
using namespace std;

int GetSquared(int a, int b)
{
    int origin = a;
    for(int i = 2; i <= b; i++)
    {
        origin *= a;
    }

    return origin;
}

int main() 
{
    int a, b;

    cin >> a >> b;

    cout << GetSquared(a,b);

    return 0;
}
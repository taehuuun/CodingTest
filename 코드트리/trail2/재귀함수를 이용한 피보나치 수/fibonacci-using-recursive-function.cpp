#include <iostream>
using namespace std;

int Fibonachi(int n)
{
    if(n == 1)
    {
        return 1;
    }

    if(n == 2)
    {
        return 1;
    }

    return Fibonachi(n-1) + Fibonachi(n-2);
}

int main() 
{
    int n;

    cin >> n;

    cout << Fibonachi(n);

    return 0;
}
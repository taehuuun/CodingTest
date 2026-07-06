#include <iostream>
using namespace std;

int main() 
{
    int a, b, prod = 1;

    cin >> a >> b;

    for(int i = a; i <= b; i++)
    {
        prod *= i;
    }

    cout << prod;

    return 0;
}
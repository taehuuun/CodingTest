#include <iostream>
using namespace std;

int main() 
{
    int a, b, prod = 1;

    cin >> a >> b;

    for(int i = 0; i < b; i++)
    {
        prod *= a;
    }

    cout << prod;

    return 0;
}
#include <iostream>
using namespace std;

int main() 
{
    int a, b, prod = 1;

    cin >> a >> b;

    for(int i = 1; i <= b; i++)
    {
        if(i % a == 0)
        {
            prod *= i;
        }
    }

    cout << prod;

    return 0;
}
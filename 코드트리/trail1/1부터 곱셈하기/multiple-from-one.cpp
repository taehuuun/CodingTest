#include <iostream>
using namespace std;

int main() 
{
    int n, prod = 1;

    cin >> n;

    for(int i = 2; i <= 10; i++)
    {
        prod *= i;

        if(prod >= n)
        {
            cout << i;
            break;
        }
    }

    return 0;
}
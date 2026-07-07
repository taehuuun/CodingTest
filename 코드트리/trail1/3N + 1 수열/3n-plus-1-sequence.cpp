#include <iostream>
using namespace std;

int main() 
{
    int n, count = 0;

    cin >> n;

    while(true)
    {
        if(n == 1)
        {
            cout << count;
            break;
        }

        if(n % 2 == 0)
        {
            n /= 2;
            count++;
        }
        else
        {
            n = n * 3 + 1;
            count++;
        }
    }

    return 0;
}
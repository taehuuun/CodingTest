#include <iostream>
using namespace std;

void GCD(int n, int m)
{
    int gcd = -999;
    int target = n >= m ? n : m;

    for(int i = 1 ; i <= target; i++)
    {
        if(n % i == 0 && m % i == 0)
        {
            if(gcd < i)
            {
                gcd = i;
            }
        }
    }

    cout << n *m / gcd;
}

int main() 
{
    int n, m;

    cin >> n >> m;

    GCD(n, m);

    return 0;
}
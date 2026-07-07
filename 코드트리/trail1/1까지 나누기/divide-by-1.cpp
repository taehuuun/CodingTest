#include <iostream>
using namespace std;

int main() 
{
    int n = 0, count = 1;

    cin >> n;

    for(int i = 1; ; i++)
    {
        n /= i;

        if(n <= 1)
        {
            cout << i;
            break;
        }
    }

    return 0;
}
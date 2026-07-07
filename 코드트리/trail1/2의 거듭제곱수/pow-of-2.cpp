#include <iostream>
using namespace std;

int main() 
{
    int n, i = 1, count = 1;

    cin >> n;

    while(true)
    {
        i *= 2;

        if(i == n)
        {
            cout << count;
            break;
        }

        count++;
    }

    return 0;
}
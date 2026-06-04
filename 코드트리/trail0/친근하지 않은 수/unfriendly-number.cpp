#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    int count = 1;

    for(int i = 1; i <= n; i++)
    {
        if(i == 1)
        {
            continue; 
        }

        if(i % 2 == 0 || i % 3 == 0 || i % 5 == 0)
        {
            continue;
        }

        count++;
    }

    cout << count;

    return 0;
}
#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    for(int y = 0; y < n; y++)
    {
        for(int x = n; x > 0; x--)
        {
            cout << x << " ";
        }

        cout << endl;
    }

    return 0;
}
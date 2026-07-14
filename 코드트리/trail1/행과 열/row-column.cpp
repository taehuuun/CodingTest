#include <iostream>
using namespace std;

int main() 
{
    int a, b;

    cin >> a >> b;

    for(int y = 0; y < a; y++)
    {
        for(int x = 0; x < b; x++)
        {
            cout << (x + 1) * (y + 1) << " ";
        }

        cout << endl;
    }

    return 0;
}
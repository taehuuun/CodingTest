#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    for(int i = 0; i < 2; i++)
    {
        for(int y = 0; y < n; y++)
        {
            for(int x = 0; x < n; x++)
            {
                cout << "*";
            }

            cout << endl;
        }

        cout << endl;
    }

    return 0;
}
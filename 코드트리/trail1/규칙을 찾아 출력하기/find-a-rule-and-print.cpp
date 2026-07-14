#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    for(int y = 0; y < n; y++)
    {
        for(int x = 0; x < n; x++)
        {
            if(x == 0 || y == 0 || x == n - 1 || y == n -1 || x < y)
            {
                cout << "* ";
            }
            else
            {
                cout << "  ";
            }

        }
        cout << endl;
    }

    return 0;
}
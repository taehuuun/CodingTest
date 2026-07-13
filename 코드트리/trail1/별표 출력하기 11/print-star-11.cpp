#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    for(int y = 0; y < 2 * n +1; y++)
    {
        for(int x = 0; x < 2 * n +1; x++)
        {
            if(y == 0 || x == 0 || x == 2 * n || y == 2 * n || x % 2 == 0 || y % 2 == 0)
            {
                cout << "* ";
            }
            else
            {
                cout << "  ";
            }
        }

        cout <<endl;
    }

    return 0;
}
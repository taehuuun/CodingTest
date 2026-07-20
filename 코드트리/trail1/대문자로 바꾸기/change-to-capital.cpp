#include <iostream>
using namespace std;

int main() 
{
    char input;

    for(int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            cin >> input;

            cout << ((char)((int)input - 32)) << ' ';
        }

        cout << endl;
    }

    return 0;
}
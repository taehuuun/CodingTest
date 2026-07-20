#include <iostream>
using namespace std;

int main() 
{
    int input;

    for(int i = 0 ; i < 4; i++)
    {
        int sum = 0;
        for(int i = 0 ; i < 4; i++)
        {
            cin >> input;

            sum += input;
        }

        cout << sum << endl;
    }

    return 0;
}
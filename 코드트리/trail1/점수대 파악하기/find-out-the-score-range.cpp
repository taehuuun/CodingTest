#include <iostream>
using namespace std;

int main() 
{
    int input, countArr[10] = { };

    while(true)
    {
        cin >> input;

        if(input == 0)
        {
            break;
        }

        countArr[input/10 - 1]++;
    }

    for(int i = 9; i >= 0; i--)
    {
        cout << (i + 1) * 10 << " - " << countArr[i] << endl;
    }

    return 0;
}
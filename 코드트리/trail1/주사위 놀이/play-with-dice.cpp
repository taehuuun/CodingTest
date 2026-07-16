#include <iostream>
using namespace std;

int main() 
{
    int input, countArr[7] = { };

    for(int i = 0; i < 10; i++)
    {
        cin >> input;

        countArr[input]++;
    }

    for(int i = 1; i <= 6; i++)
    {
        cout << i << " - " << countArr[i] << endl;
    }

    return 0;
}
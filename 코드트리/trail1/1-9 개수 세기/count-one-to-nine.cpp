#include <iostream>
using namespace std;

int main() 
{
    int n, input, countArr[9] = {};

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        cin >> input;

        countArr[input - 1]++;
    }

    for(int i = 0; i < 9; i++)
    {
        cout << countArr[i] << endl;
    }

    return 0;
}
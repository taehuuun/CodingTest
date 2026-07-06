#include <iostream>
using namespace std;

int main() 
{
    int n, sum = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int input;

        cin >> input;

        sum += input;
    }

    cout << sum << " ";

    cout << fixed;
    cout.precision(1);

    cout << (float)sum / n;

    return 0;
}
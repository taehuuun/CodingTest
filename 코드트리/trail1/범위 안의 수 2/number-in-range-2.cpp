#include <iostream>
using namespace std;

int main() 
{
    int count = 0, sum = 0;

    for(int i = 0; i < 10; i++)
    {
        int input;

        cin >> input;

        if(input >= 0 && input <= 200)
        {
            sum += input;
            count++;
        }
    }

    cout << sum << " ";

    cout << fixed;
    cout.precision(1);

    cout << (float)sum / count;

    return 0;
}
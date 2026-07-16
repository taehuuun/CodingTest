#include <iostream>
using namespace std;

int main() 
{
    int arr[10];
    int input, cnt = 0, sum = 0;

    for(int i = 0; i < 10; i++)
    {
        cin >> input;

        if(input == 0)
        {
            break;
        }

        sum += input;
        cnt++;
    }

    cout << sum << " ";

    cout << fixed;
    cout.precision(1);

    cout << (float)sum / cnt;

    return 0;
}
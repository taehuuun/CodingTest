#include <iostream>
using namespace std;

int main() 
{
    int sum = 0, cnt = 0;

    for(int i = 0 ; i < 10; i++)
    {
        int input;
        cin >> input;

        if(input >= 250)
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
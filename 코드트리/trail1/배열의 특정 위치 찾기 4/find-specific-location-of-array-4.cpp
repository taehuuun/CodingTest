#include <iostream>
using namespace std;

int main() 
{
    int input, cnt = 0, sum = 0;

    for(int i = 0 ; i < 10; i++)
    {
        cin >> input;

        if(input == 0)
        {
            break;
        }

        if(input % 2 == 0)
        {
            sum += input;
            cnt++;
        }
    }

    cout << cnt << " " << sum;

    return 0;
}
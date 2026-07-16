#include <iostream>
using namespace std;

int main() 
{
    int n, input, sum = 0, cnt = 0;
    float avg = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        sum = 0;

        for(int j = 0; j < 4; j++)
        {
            cin >> input;

            sum += input;
        }

        avg = (float)sum / 4;

        if(avg >= 60)
        {
            cout <<"pass" << endl;
            cnt++;
        }
        else
        {
            cout <<"fail" << endl;
        }
    }

    cout << cnt;

    return 0;
}
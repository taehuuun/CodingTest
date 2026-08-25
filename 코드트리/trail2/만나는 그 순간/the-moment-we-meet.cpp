#include <iostream>
using namespace std;

int main() 
{
    const int OFF_SET = 1000 * 1000;
    const int ARR_SIZE = 2 * OFF_SET + 1;

    int n, m, a[ARR_SIZE] = {}, b[ARR_SIZE] = {}, curAPos = OFF_SET, curBPos = OFF_SET;

    cin >> n >> m;
    
    int aSec = 1;
    for(int i = 0; i < n; i++)
    {
        char dir;
        int value;

        cin >> dir >> value;

        if(dir == 'R')
        {
            for(int x = curAPos + 1; x <= curAPos + value; x++)
            {
                a[aSec] = x;
                aSec++;
            }
            curAPos += value;
        }
        else
        {
            for(int x = curAPos - 1; x >= curAPos - value; x--)
            {
                a[aSec] = x;
                aSec++;
            }

            curAPos -= value;
        }
    }

    int bSec = 1;
    for(int i = 0; i < m; i++)
    {
        char dir;
        int value;

        cin >> dir >> value;

        if(dir == 'R')
        {
            for(int x = curBPos + 1; x <= curBPos + value; x++)
            {
                b[bSec] = x;
                bSec++;
            }
            curBPos += value;
        }
        else
        {
            for(int x = curBPos - 1; x >= curBPos - value; x--)
            {
                b[bSec] = x;
                bSec++;
            }

            curBPos -= value;
        }
    }


    for(int i = 1; i < aSec; i++)
    {
        if(a[i] == b[i])
        {
            cout << i;
            return 0;
        }
    }

    cout << "-1";

    return 0;
}
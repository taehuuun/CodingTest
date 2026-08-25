#include <iostream>
using namespace std;

void UpdateArrayPosition(int *arr, int time, int value)
{
    arr[time] = value;
}

int main()
{
    const int MAX_SIZE = 2'000'000;

    int aArr[MAX_SIZE] = { }, bArr[MAX_SIZE] = {};
    int n, m, aCurrentPos = 0, bCurrentPos = 0, aTime = 1, bTime = 1; 

    cin >> n >> m;

    for(int i = 0; i < n; i++)
    {
        int t;
        char d;

        cin >> t >> d;

        int targetTime = aTime + t;

        if(d == 'R')
        {
            for( ; aTime < targetTime; aTime++)
            {
                aCurrentPos++;
                UpdateArrayPosition(aArr, aTime, aCurrentPos);
            }
        }
        else
        {
            for( ; aTime < targetTime; aTime++)
            {
                aCurrentPos--;
                UpdateArrayPosition(aArr, aTime, aCurrentPos);
            }
        }
    }

    for(int i = 0; i < m; i++)
    {
        int t;
        char d;

        cin >> t >> d;

        int targetTime = bTime + t;

        if(d == 'R')
        {
            for( ; bTime < targetTime; bTime++)
            {
                bCurrentPos++;
                UpdateArrayPosition(bArr, bTime, bCurrentPos);
            }
        }
        else
        {
            for( ; bTime < targetTime; bTime++)
            {
                bCurrentPos--;
                UpdateArrayPosition(bArr, bTime, bCurrentPos);
            }
        }
    }


    int totalTime = aTime > bTime ? aTime : bTime;
    int count = 0, aPos, bPos, aPrevPos = aArr[1], bPrevPos = bArr[1];
    for(int i = 1; i < totalTime; i++)
    {
        aPos = (i - 1 >= aTime) ? aArr[aTime-1] : aArr[i];
        bPos = (i - 1 >= bTime) ? bArr[bTime-1] : bArr[i];

        if(aPos == bPos && aPrevPos != bPrevPos)
        {
            count++;
        }

        aPrevPos = aPos;
        bPrevPos = bPos;
    }
    
    cout << count;

    return 0;
}
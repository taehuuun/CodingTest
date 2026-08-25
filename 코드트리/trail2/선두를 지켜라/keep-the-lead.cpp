#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 1000 * 1000;

    int n, m, aArr[MAX_SIZE] = { }, bArr[MAX_SIZE] = { };

    cin >> n >> m;

    int aTime = 1;
    for(int i = 0; i < n; i++)
    {
        int speed, time;
        cin >> speed >> time;

        for(int t = 0; t < time; t++)
        {
            aArr[aTime] += speed + aArr[aTime - 1];
            aTime++;
        }
    }

    int bTime = 1;
    for(int i = 0; i < m; i++)
    {
        int speed, time;
        cin >> speed >> time;

        for(int t = 0; t < time; t++)
        {
            bArr[bTime] += speed + bArr[bTime - 1];
            bTime++;
        }
    }

    char winner = 'N';
    int changeCnt = 0;

    for(int i = 1; i < aTime; i++)
    {
        if(aArr[i] > bArr[i])
        {
            if(winner == 'A')
            {
                continue;
            }

            changeCnt++;
            winner = 'A';
        }
        else if(aArr[i] < bArr[i])
        {
            if(winner == 'B')
            {
                continue;
            }

            changeCnt++;
            winner = 'B';
        }
    }

    cout << changeCnt - 1;

    return 0;
}
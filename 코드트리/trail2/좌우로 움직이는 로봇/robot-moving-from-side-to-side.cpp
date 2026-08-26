#include <iostream>
using namespace std;

void UpdateArrayPosition(int *arr, int time, int value);
void InputRobotData(int inputCnt, int *robot, int *time, int *position);

constexpr int MAX_SIZE = 2'000'000;
int aArr[MAX_SIZE] = { }, bArr[MAX_SIZE] = {};

int main()
{
    int n, m, aCurrentPos = 0, bCurrentPos = 0, aTime = 1, bTime = 1;

    cin >> n >> m;

    InputRobotData(n, aArr, &aTime, &aCurrentPos);
    InputRobotData(m, bArr, &bTime, &bCurrentPos);

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

void UpdateArrayPosition(int *arr, int time, int value)
{
    arr[time] = value;
}

void InputRobotData(int inputCnt, int *robot, int *time, int *position)
{
    for(int i = 0; i < inputCnt; i++)
    {
        int t;
        char d;

        cin >> t >> d;

        const int targetTime = *time + t;

        if(d == 'R')
        {
            for( ; *time < targetTime; (*time)++)
            {
                (*position)++;
                UpdateArrayPosition(robot, *time, *position);
            }
        }
        else
        {
            for( ; *time < targetTime; (*time)++)
            {
                (*position)--;
                UpdateArrayPosition(robot, *time, *position);
            }
        }
    }
}
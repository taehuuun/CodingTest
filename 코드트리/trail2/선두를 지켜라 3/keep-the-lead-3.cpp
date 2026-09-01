#include <iostream>
using namespace std;

const int MAX_SIZE = 1'000'000;
int aArr[MAX_SIZE] = {}, bArr[MAX_SIZE] = {}, aPos = 0, bPos = 0, aTime = 1, bTime = 1;

void ProcessInputArray(int inputCnt, int* time, int* position, int* arr)
{
    for(int i = 0; i < inputCnt; i++)
    {
        int v, t;
        cin >> v >> t;

        int targetTime = *time + t;
        for( ;*time < targetTime; (*time)++)
        {
            (*position) += v;
            arr[*time] = *position;
        }
    }
}

int main()
{
    int n, m, count = 0;

    cin >> n >> m;

    ProcessInputArray(n, &aTime, &aPos, aArr);
    ProcessInputArray(m, &bTime, &bPos, bArr);

    char prevState = 'E';

    for(int i = 1; i < aTime; i++)
    {
        if(aArr[i] == bArr[i])
        {
            if(prevState == 'S')
            {
                continue;
            }

            count++;
            prevState = 'S';
        }
        else if(aArr[i] > bArr[i])
        {
            if(prevState == 'A')
            {
                continue;
            }

            count++;
            prevState = 'A';
        }
        else
        {
            if(prevState == 'B')
            {
                continue;
            }

            count++;
            prevState = 'B';
        }
    }

    cout << count;

    return 0;
}
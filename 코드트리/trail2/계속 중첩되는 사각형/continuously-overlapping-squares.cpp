#include <iostream>
using namespace std;

int main() 
{
    const int OFF_SET = 100;
    const int ARR_SIZE = 2 * OFF_SET + 1;

    int n;
    char arr[ARR_SIZE][ARR_SIZE] = {};

    for(int y = 0; y < ARR_SIZE; y++)
    {
        for(int x = 0; x < ARR_SIZE; x++)
        {
            arr[y][x] = 'E';
        }
    }

    cin >> n;

    char currentColor = 'R';

    for(int i = 0; i < n; i++)
    {
        int x1,y1,x2,y2;

        cin >> x1 >> y1 >> x2 >> y2;

        for(int y = y1 + OFF_SET; y < y2 + OFF_SET; y++)
        {
            for(int x = x1 + OFF_SET; x < x2 + OFF_SET; x++)
            {
                arr[y][x] = currentColor;
            }
        }

        currentColor = currentColor == 'R' ? 'B' : 'R';
    }

    int blueCnt = 0;
    for(int y = 0; y < ARR_SIZE; y++)
    {
        for(int x = 0; x < ARR_SIZE; x++)
        {
            if(arr[y][x] == 'B')
            {
                blueCnt++;
            }
        }
    }

    cout << blueCnt;

    return 0;
}
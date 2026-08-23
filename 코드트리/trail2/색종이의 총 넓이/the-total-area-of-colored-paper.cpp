#include <iostream>
using namespace std;

int main() 
{
    const int OFF_SET = 100;
    const int ARR_SIZE = 2 * OFF_SET + 1;

    int arr[ARR_SIZE][ARR_SIZE] = {};
    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int xi, yi;

        cin >> xi >> yi;

        for(int y = yi + OFF_SET; y < yi + 8 + OFF_SET; y++)
        {
            for(int x = xi + OFF_SET; x < xi + 8 + OFF_SET; x++)
            {
                arr[y][x] = 1;
            }
        }
    }

    int area = 0;
    for(int y = 0; y < ARR_SIZE; y++)
    {
        for(int x = 0; x < ARR_SIZE; x++)
        {
            if(arr[y][x] == 0)
            {
                continue;
            }

            area++;
        }
    }

    cout << area;

    return 0;
}
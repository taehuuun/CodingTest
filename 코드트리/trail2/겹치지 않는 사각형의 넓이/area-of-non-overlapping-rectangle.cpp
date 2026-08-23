#include <iostream>
using namespace std;

int main() 
{
    const int OFF_SET = 1000;
    const int ARR_SIZE = 2 * OFF_SET + 1;
    int arr[ARR_SIZE][ARR_SIZE] = {};

    int ax1, ay1, ax2, ay2;
    int bx1, by1, bx2, by2;
    int mx1, my1, mx2, my2;

    cin >> ax1 >> ay1 >> ax2 >> ay2;
    cin >> bx1 >> by1 >> bx2 >> by2;
    cin >> mx1 >> my1 >> mx2 >> my2;

    for(int y = ay1 + OFF_SET; y <= ay2 - 1 + OFF_SET; y++)
    {
        for(int x = ax1 + OFF_SET; x <= ax2 -1 + OFF_SET; x++)
        {
            arr[y][x] = 1;
        }
    }

    for(int y = by1 + OFF_SET; y <= by2 - 1 + OFF_SET; y++)
    {
        for(int x = bx1 + OFF_SET; x <= bx2 -1 + OFF_SET; x++)
        {
            arr[y][x] = 1;
        }
    }

    for(int y = my1 + OFF_SET; y <= my2 -1 + OFF_SET; y++)
    {
        for(int x = mx1 + OFF_SET; x <= mx2 - 1 + OFF_SET; x++)
        {
            arr[y][x] = 0;
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
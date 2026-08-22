#include <iostream>

using namespace std;

int main() 
{
    const int OFF_SET = 100;
    const int ARR_SIZE = 2 * OFF_SET + 1;

    int n, arr[ARR_SIZE][ARR_SIZE] = {};

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int x1, y1, x2, y2;

        cin >> x1 >> y1 >> x2 >> y2;

        x1 += OFF_SET;
        y1 += OFF_SET;
        x2 += OFF_SET;
        y2 += OFF_SET;

        for(int y = y1; y <= y2 - 1; y++)
        {
            for(int x = x1; x <= x2 - 1; x++)
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
            if(arr[y][x] == 1)
            {
                area++;
            }
        }
    }

    cout << area;

    return 0;
}
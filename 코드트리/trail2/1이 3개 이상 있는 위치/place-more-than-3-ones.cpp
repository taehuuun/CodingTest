#include <iostream>

using namespace std;

int main() 
{
    const int MAX_SIZE = 100;
    int n, arr[MAX_SIZE][MAX_SIZE] = {}, dx[4] = {0, 0, -1, 1}, dy[4] = {-1, 1, 0, 0};
    
    cin >> n;

    for(int y = 0; y < n; y++)
    {
        for(int x = 0; x < n; x++)
        {
            cin >> arr[y][x];
        }
    }

    int findCnt = 0;
    for(int y = 0; y < n; y++)
    {
        for(int x = 0; x < n; x++)
        {
            int count  = 0;

            for(int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                if(nx < 0 || nx >= n || ny < 0 || ny >= n)
                {
                    continue;
                }

                if(arr[ny][nx] == 1)
                {
                    count++;
                }
            }

            if(count >= 3)
            {
                findCnt++;
            }
        }
    }

    cout << findCnt;

    return 0;
}
#include <iostream>
using namespace std;

int GetDir(const char dir)
{
    if(dir == 'U')
    {
        return 0;
    }

    if(dir == 'D')
    {
        return 3;
    }

    if(dir == 'R')
    {
        return 2;
    }

    if(dir == 'L')
    {
        return 1;
    }
}

int main()
{
    int n, t, posX = 0, posY = 0;
    char startDir;

    cin >> n >> t >> posY >> posX >> startDir;

    int dir = GetDir(startDir);

    for(int i = 0; i < t; i++)
    {
        constexpr int dy[4] = {-1 , 0, 0 ,1};
        constexpr int dx[4] = {0, -1, 1, 0};
        const int nx = posX + dx[dir];
        const int ny = posY + dy[dir];

        if(nx <= 0 || nx > n || ny <= 0 || ny > n)
        {
            dir = 3 - dir;
        }
        else
        {
            posX = nx;
            posY = ny;
        }
    }

    cout << posY << ' ' << posX;

    return 0;
}
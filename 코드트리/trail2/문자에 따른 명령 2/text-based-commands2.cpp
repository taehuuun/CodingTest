#include <iostream>
#include <string>

using namespace std;

int main() 
{
    int dir = 0, dy[4] = { 1, 0, -1, 0}, dx[4] = {0, 1, 0, -1};
    int posX = 0, posY = 0;

    string command;

    cin >> command;

    for(int i = 0; i < command.length(); i++)
    {
        switch(command[i])
        {
            case 'L':
                dir = (dir - 1 + 4) % 4;
                break;
            case 'R':
                dir = (dir + 1) % 4;
                break;
            case 'F':
                posX += dx[dir];
                posY += dy[dir];
                break;
        }
    }

    cout << posX << ' ' << posY;

    return 0;
}
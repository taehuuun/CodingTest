#include <iostream>
using namespace std;

int main() 
{
    int dx[2] = {-1, 1}, dy[2] = {1, -1};
    int n, posX = 0, posY = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        char command;
        int value;

        cin >> command >> value;

        switch(command)
        {
            case 'N':
                posY += dy[0] * value;
                break;
            case 'S':
                posY += dy[1] * value;
                break;
            case 'W':
                posX += dx[0] * value;
                break;
            case 'E':
                posX += dx[1] * value;
                break;
        }
    }

    cout << posX << ' ' << posY;

    return 0;
}
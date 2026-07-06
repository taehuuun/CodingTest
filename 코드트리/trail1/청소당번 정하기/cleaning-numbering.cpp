#include <iostream>
using namespace std;

int main() 
{
    int n;
    int classRoom = 0, corridor = 0, restRoom = 0;

    cin >> n;

    for(int i = 1; i <= n; i++)
    {
        if(i % 12 == 0)
        {
            restRoom++;
        }
        else if(i % 3 == 0)
        {
            corridor++;
        }
        else if(i % 2 == 0)
        {
            classRoom++;
        }
    }

    cout << classRoom << " " << corridor << " " << restRoom;

    return 0;
}
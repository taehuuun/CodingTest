#include <iostream>
using namespace std;

int main() 
{
    char arr[6] = { 'L', 'E', 'B', 'R', 'O', 'S' };
    char input;
    bool isFind = false;
    int findIdx = 0;

    cin >> input;

    for(int i = 0; i < 6; i++)
    {
        if(arr[i] == input)
        {
            isFind = true;
            findIdx = i;
            break;
        }
    }

    if(isFind)
    {
        cout << findIdx;
    }
    else
    {
        cout << "None";
    }

    return 0;
}
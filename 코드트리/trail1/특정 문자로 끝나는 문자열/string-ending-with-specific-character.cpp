#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string arr[10];
    char target;
    bool isFind = false;

    for(int i = 0; i < 10; i++)
    {
        cin >> arr[i];
    }

    cin >> target;

    for(int i = 0; i < 10; i++)
    {
        int len = arr[i].length();
        if(arr[i][len-1] == target)
        {
            cout << arr[i] << endl;
            isFind = true;
        }
    }

    if(!isFind)
    {
        cout << "None";
    }

    return 0;
}
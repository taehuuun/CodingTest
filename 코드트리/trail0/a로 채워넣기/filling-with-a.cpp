#include <iostream>
using namespace std;

int main() 
{
    char arr[101];
    
    cin >> arr;

    int len = 0;

    arr[1] = 'a';

    for(int i = 0 ; i < sizeof(arr); i++)
    {
        if(arr[i] == '\0')
        {
            break;
        }

        len++;
    }


    arr[len - 2] = 'a';

    for(int i = 0 ; i< sizeof(arr); i++)
    {
        if(arr[i] == '\0')
        {
            break;
        }

        cout << arr[i];
    }

    return 0;
}
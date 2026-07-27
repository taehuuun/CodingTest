#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input, arr[201];
    int idx = 0;

    while(true)
    {
        cin >> input;

        if(input == "0")
        {
            break;
        }

        arr[idx] = input;
        idx++;
    }

    cout << idx << endl;

    for(int i = 0; i < idx; i++)\
    {
        if(i % 2 == 0)
        {
            cout << arr[i] << endl;
        }
    }

    return 0;
}
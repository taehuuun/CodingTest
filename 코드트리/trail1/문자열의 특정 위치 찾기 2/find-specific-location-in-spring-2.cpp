#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string str[5] = { "apple" , "banana", "grape", "blueberry", "orange" };
    char target;
    int count = 0;

    cin >> target;

    for(int i = 0 ; i < 5; i++)
    {
        if(str[i][2] == target || str[i][3] == target)
        {
            cout << str[i] << endl;
            count++;
        }
    }

    cout << count;

    return 0;
}
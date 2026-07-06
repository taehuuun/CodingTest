#include <iostream>
using namespace std;

int main() 
{
    int count = 0;

    for(int i = 0 ; i < 5; i++)
    {
        int input;

        cin >> input;

        if(input % 2 == 0)
        {
            count++;
        }
    }

    cout << count;

    return 0;
}
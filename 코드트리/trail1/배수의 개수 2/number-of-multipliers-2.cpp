#include <iostream>
using namespace std;

int main() 
{
    int cnt = 0;
    for(int i = 0 ; i < 10 ; i++)
    {
        int input;

        cin >> input;

        if(input % 2 != 0)
        {
            cnt++;
        }
    }
    
    cout << cnt;

    return 0;
}
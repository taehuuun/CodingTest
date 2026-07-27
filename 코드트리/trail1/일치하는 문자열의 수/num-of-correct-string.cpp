#include <iostream>
#include <string>

using namespace std;

int main() 
{
    int n, cnt = 0;
    string origin;

    cin >> n >> origin;

    for(int i = 0; i < n; i++)
    {
        string input;
        cin >> input;

        if(origin == input)
        {
            cnt++;
        }
    }

    cout << cnt;

    return 0;
}
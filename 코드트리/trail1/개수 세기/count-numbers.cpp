#include <iostream>
using namespace std;

int main() 
{
    int n, m, input, cnt = 0;

    cin >> n >> m;

    for(int i = 0 ; i < n; i++)
    {
        cin >> input;

        if(input == m)
        {
            cnt++;
        }
    }

    cout << cnt;

    return 0;
}
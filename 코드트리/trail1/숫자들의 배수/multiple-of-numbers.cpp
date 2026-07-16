#include <iostream>
using namespace std;

int main() 
{
    int n, cnt = 0;

    cin >> n;

    for(int i = n; cnt < 2; i+= n)
    {
        if(i % 5 == 0)
        {
            cnt++;
        }

        cout << i << " ";
    }

    return 0;
}
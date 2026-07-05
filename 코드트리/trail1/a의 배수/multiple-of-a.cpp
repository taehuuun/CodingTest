#include <iostream>
using namespace std;

int main() 
{
    int n, a;

    cin >> n >> a;

    int i = 1;

    while(i <= n)
    {
        if(i % a == 0)
        {
            cout << "1";
        }
        else
        {
            cout << "0";
        }

        cout << endl;

        i++;
    }

    return 0;
}
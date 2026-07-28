#include <iostream>
#include <string>

using namespace std;


int main() 
{
    string a, b;
    int n = 0, len;

    cin >> a >> b;

    len = a.length();

    for(int i = 0; i < len; i++)
    {
        a = a.substr(len-1, 1) + a.substr(0, len-1);
        n++;

        if(a == b)
        {
            break;
        }
    }

    cout << (n >= len -1 ? -1 : n);

    return 0;
}
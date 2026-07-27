#include <iostream>
#include <string>
#include <cctype>

using namespace std;

int main() 
{
    string a, b, aTmp, bTmp;

    cin >> a >> b;

    for(int i = 0; i < a.length(); i++)
    {
        if(!isdigit(a[i]))
        {
            break;
        }

        aTmp += a[i];
    }

    for(int i = 0; i < b.length(); i++)
    {
        if(!isdigit(b[i]))
        {
            break;
        }

        bTmp += b[i];
    }

    cout << stoi(aTmp) + stoi(bTmp);

    return 0;
}
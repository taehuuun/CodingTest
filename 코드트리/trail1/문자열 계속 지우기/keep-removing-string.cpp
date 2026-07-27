#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string a, b;

    cin >> a >> b;

    int bLen = b.length();

    while(a.find(b) != string::npos)
    {
        int findIdx = a.find(b);

        a.erase(findIdx, bLen);
    }

    cout << a;

    return 0;
}
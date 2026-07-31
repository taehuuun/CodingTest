#include <iostream>
#include <string>

using namespace std;

bool IsDiffAlpha(string str)
{
    int cnt = 0;

    for(int i = 0; i < str.length()-1; i++)
    {
        if(str[i] != str[i+1])
        {
            cnt++;
        }
    }

    return cnt >= 1;
}

int main() 
{
    string str;

    cin >> str;

    cout << (IsDiffAlpha(str) ? "Yes" : "No");

    return 0;
}
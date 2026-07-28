#include <iostream>
#include <string>
using namespace std;

bool IsPerfectNumber(int n)
{
    if(n % 2 == 0)
    {
        return false;
    }

    string str = to_string(n);
    if(str[str.length()-1] - '0' == 5)
    {
        return false;
    }

    if(n % 3 == 0 && n % 9 != 0)
    {
        return false;
    }

    return true;
}

int GetPerfectNumberCount(int a, int b)
{
    int cnt = 0;

    cin >> a >> b;

    for(int i = a; i <= b; i++)
    {
        if(IsPerfectNumber(i))
        {
            cnt++;
        }
    }

    return cnt;
}

int main() 
{
    int a, b;

    cout << GetPerfectNumberCount(a, b);

    return 0;
}
#include <iostream>

using namespace std;

bool Is369(int n)
{
    bool isFind = false;

    while(n != 0)
    {
        int mod = n % 10;

        if(mod == 3 || mod == 6 || mod == 9)
        {
            isFind = true;
            break;
        }

        n /= 10;        
    }

    return isFind;
}

bool IsMultiOfThree(int n)
{
    return n % 3 == 0;
}

int FindCondNumCount(int a, int b)
{
    int cnt = 0;

    for(int i = a; i <= b; i++)
    {
        if(Is369(i) || IsMultiOfThree(i))
        {
            cnt++;
        }
    }

    return cnt;
}

int main() 
{
    int a, b;

    cin >> a >> b;

    cout << FindCondNumCount(a, b);

    return 0;
}
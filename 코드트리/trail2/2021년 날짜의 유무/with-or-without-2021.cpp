#include <iostream>
using namespace std;

bool Is31DayMonth(int m)
{
    return m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12;
}

bool ExistDate(int m, int d)
{
    if(1 > m || m > 12)
    {
        return false;
    }

    if(1 > d || d > 31)
    {
        return false;
    }

    if(m == 2 && d > 28)
    {
        return false;
    }

    if(Is31DayMonth(m))
    {
        if(d > 31)
        {
            return false;
        }

        return true;
    }
    else
    {
        if(d > 30)
        {
            return false;
        }

        return true;
    }
}

int main() 
{
    int m, d;

    cin >> m >> d;

    cout << (ExistDate(m, d) ? "Yes" : "No");

    return 0;
}
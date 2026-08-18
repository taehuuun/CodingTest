#include <iostream>
#include <string>

using namespace std;

string GetDay(int diff)
{
    string dayName[7] = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};

    if(diff < 0)
    {
        diff += 7;
    }

    if(diff > 7)
    {
        diff -= 7;
    }

    return dayName[diff];
}

int main() 
{
    int dayOfMonth[13] = {0,31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    int m1, d1, m2, d2, startDay = 0, endDay = 0;

    cin >> m1 >> d1 >> m2 >> d2;

    for(int i = 1; i < m1; i++)
    {
        startDay += dayOfMonth[i];
    }

    startDay += d1;

    for(int i = 1; i < m2; i++)
    {
        endDay += dayOfMonth[i];
    }

    endDay += d2;

    int diff = endDay - startDay;

    cout << GetDay(diff % 7);

    return 0;
}
#include <iostream>
#include <string>

using namespace std;

int main() 
{
    int dayOfMonth[13] = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    string dayOfWeek[7] = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

    int m1, m2, d1, d2, startDay = 0, endDay = 0, count = 0;
    string targetDay;

    cin >> m1 >> d1 >> m2 >> d2;
    cin >> targetDay;

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

    for(int i = 0; i < 7; i++)
    {
        if(dayOfWeek[i] == targetDay)
        {
            count++;
            break;
        }

        if(diff <= 0)
        {
            break;
        }

        diff--;
    }

    if(diff > 0)
    {
        count += diff / 7;
    }

    cout << count;

    return 0;
}
#include <iostream>
#include <string>

using namespace std;

class Day
{
    public:
        string date;
        string dayOfWeek;
        string weather;
};

int GetDay(string day)
{
    if(day == "Mon")
    {
        return 0;
    }

    if(day == "Tue")
    {
        return 1;
    }

    if(day == "Wed")
    {
        return 2;
    }

    if(day == "Thu")
    {
        return 3;
    }

    if(day == "Fri")
    {
        return 4;
    }

    if(day == "Sat")
    {
        return 5;
    }

    if(day == "sun")
    {
        return 6;
    }
}

bool EarlierDate(string curDate, string curDayOfWeek, string targetDate, string targetDayOfWeek)
{
    int curYear = stoi(curDate.substr(0,4));
    int curMonth = stoi(curDate.substr(5,2));
    int curDay = stoi(curDate.substr(8,2));
    int targetYear = stoi(targetDate.substr(0,4));
    int targetMonth = stoi(targetDate.substr(5,2));
    int targetDay = stoi(targetDate.substr(8,2));

    if(curYear == targetYear)
    {
        if(curMonth == targetMonth)
        {
            if(curDay == targetDay)
            {
                if(GetDay(curDayOfWeek) == GetDay(targetDayOfWeek))
                {
                    return false;
                }
            }
            else
            {
                return curDay < targetDay;
            }
        }
        else
        {
            return curMonth < targetMonth;
        }
    }
    else 
    {
        return curYear < targetYear;
    }
}

int main() 
{
    const int MAX_SIZE = 100;

    Day days[MAX_SIZE];
    int n, rainCount = 0, rainDayIdx[MAX_SIZE], minDayIdx = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> days[i].date >> days[i].dayOfWeek >> days[i].weather;
    }

    for(int i = 0; i < n; i++)
    {
        if(days[i].weather != "Rain")
        {
            continue;
        }

        rainDayIdx[rainCount] = i;
        rainCount++;
    }

    for(int i = 0; i < rainCount; i++)
    {
        string curDate = days[rainDayIdx[i]].date;
        string curDayOfWeek = days[rainDayIdx[i]].dayOfWeek;
        string targetDate = days[rainDayIdx[minDayIdx]].date;
        string targetDayOfWeek = days[rainDayIdx[minDayIdx]].dayOfWeek;

        if(EarlierDate(curDate, curDayOfWeek, targetDate, targetDayOfWeek))
        {
            minDayIdx = i;
        }
    }

    cout << days[rainDayIdx[minDayIdx]].date << ' ' << days[rainDayIdx[minDayIdx]].dayOfWeek << ' ' << days[rainDayIdx[minDayIdx]].weather;

    return 0;
}
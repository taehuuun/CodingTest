#include <iostream>
#include <string>

using namespace std;

string GetSeason(int m)
{
    if(m >= 3 && m <= 5)
    {
        return "Spring";
    }

    if(m >= 6 && m <= 8)
    {
        return "Summer";
    }

    if(m >= 9 && m <= 11)
    {
        return "Fall";
    }

    if(m <= 12 && m >= 2)
    {
        return "Winter";
    }

}

bool Is31DayMonth(int m)
{
    return m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12;
}

bool IsLeafYear(int y)
{
    if(y % 4 != 0)
    {
        return false;
    }

    if(y % 100 == 0)
    {
        if(y % 400 == 0)
        {
            return true;
        }

        return false;
    }

    return true;
}

void PrintSeason(int y, int m, int d)
{
    bool condition = (m == 2 ? (IsLeafYear(y) ? d > 29 : d > 28) : (Is31DayMonth(m) ? d > 31 : d > 30));
    
    cout << (condition ? "-1" : GetSeason(m));
}

int main() 
{
    int y, m, d;

    cin >> y >> m >> d;

    PrintSeason(y, m, d);

    return 0;
}
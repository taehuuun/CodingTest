#include <iostream>
using namespace std;

int main() 
{
    int num_of_days[13] = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    int m1,d1,m2,d2, startDay = 0, endDay = 0;

    cin >> m1 >> d1 >> m2 >> d2;

    for(int i = 1; i < m1; i++)
    {
        startDay += num_of_days[i];
    }

    for(int i = 1; i < m2; i++)
    {
        endDay += num_of_days[i];
    }

    startDay += d1;
    endDay += d2;

    cout << endDay - startDay + 1;

    return 0;
}
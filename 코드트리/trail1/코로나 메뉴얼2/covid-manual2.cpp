#include <iostream>
using namespace std;

int main() 
{
    int temp, countArr[4] = { };
    char symptoms;

    for(int i = 0; i < 3; i++)
    {
        cin >> symptoms >> temp;

        if(symptoms == 'Y' && temp >= 37)
        {
            countArr[0]++;
        }
        else if(symptoms == 'N' && temp >= 37)
        {
            countArr[1]++;
        }
        else if(symptoms == 'Y' && temp < 37)
        {
            countArr[2]++;
        }
        else
        {
            countArr[3]++;
        }
    }

    for(int i = 0; i < 4; i++)
    {
        cout << countArr[i] << " ";
    }

    if(countArr[0] >= 2)
    {
        cout << 'E';
    }

    return 0;
}
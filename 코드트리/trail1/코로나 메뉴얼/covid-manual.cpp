#include <iostream>
using namespace std;

int main() 
{
    char fisrtSymptoms, secSymptoms, thirdSymptoms;
    int  firstTemp, secTemp, thirdTemp;
    int eCount = 0;

    cin >> fisrtSymptoms >> firstTemp;
    cin >> secSymptoms >> secTemp;
    cin >> thirdSymptoms >> thirdTemp;


    if(fisrtSymptoms == 'Y' && firstTemp >= 37)
    {
        eCount++;
    }

    if(secSymptoms == 'Y' && secTemp >= 37)
    {
        eCount++;
    }

    if(thirdSymptoms == 'Y' && thirdTemp >= 37)
    {
        eCount++;
    }

    if(eCount >= 2)
    {
        cout << "E";
    }
    else
    {
        cout << "N";
    }

    return 0;
}
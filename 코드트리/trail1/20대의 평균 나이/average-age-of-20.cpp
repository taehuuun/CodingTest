#include <iostream>
using namespace std;

int main() 
{
    int age, count = 0, sum = 0;

    while(true)
    {
        cin >> age;

        if(age < 20 || age > 29)
        {
            cout << fixed;
            cout.precision(2);

            cout << (float) sum / count;
            break;
        }

        sum += age;
        count++;
    }

    return 0;
}
#include <iostream>
using namespace std;

int main() 
{
    int midterm, finalExam, money = 0;

    cin >> midterm >> finalExam;

    if(midterm >= 90)
    {
        if(finalExam >= 95)
        {
            money += 100000;
        }
        else if(finalExam >= 90)
        {
            money += 50000;
        }
    }

    cout << money;

    return 0;
}
#include <iostream>
using namespace std;

int main() 
{
    int start, end, cnt = 0;

    cin >> start >> end;

    for(int i = start; i <= end; i++)
    {
        int numOfDivisors = 0;

        for(int j = 1; j <= i; j++)
        {
            if(i % j == 0)
            {
                numOfDivisors++;
            }
        }

        if(numOfDivisors == 3)
        {
            cnt++;
        }
    }

    cout << cnt;

    return 0;
}
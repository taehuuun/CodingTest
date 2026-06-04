#include <iostream>
using namespace std;

int main() 
{
    int start, end;

    cin >> start >> end;

    int findCount = 0;

    for(int i = start; i <= end; i++)
    {
        int divisorCount = 0;
        
        for(int j = 1; j <= i; j++)
        {
            if(i % j == 0)
            {
                divisorCount++;
            }
        }

        if(divisorCount == 3)
        {
            findCount++;
        }
    }

    cout << findCount;

    return 0;
}
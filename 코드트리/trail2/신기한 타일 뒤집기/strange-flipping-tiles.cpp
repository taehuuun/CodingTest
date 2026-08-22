#include <iostream>
using namespace std;

int main() 
{
    const int OFF_SET = 100'000;
    const int ARR_SIZE = 2 *100'000 + 1;
    
    char arr[ARR_SIZE];
    int n, current = OFF_SET;

    for(int i = 0; i < ARR_SIZE; i++)
    {
        arr[i] = 'E';
    }

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int x;
        char d;

        cin >> x >> d;


        if(d == 'L')
        {
            for(int i = current; i > current - x; i--)
            {
                arr[i] = 'L';
            }

            current -= x - 1;
        }
        else
        {
            for(int i = current; i < current + x; i++)
            {
                arr[i] = 'R';
            }

            current += x - 1;
        }
    }

    int whiteCnt = 0, blackCnt = 0;

    for(int i = 0; i < ARR_SIZE; i++)
    {
        if(arr[i] == 'E')
        {
            continue;
        }

        if(arr[i] == 'L')
        {
            whiteCnt++;
        
        }
        else
        {
            blackCnt++;
        }
    }

    cout << whiteCnt << ' ' << blackCnt;

    return 0;
}
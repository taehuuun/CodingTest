#include <iostream>
using namespace std;

int main() 
{
    int arr[10];

    for(int i = 0; i < 10; i++)
    {
        cin >> arr[i];
    }

    int mulOfThreeCnt = 0;
    int mulOfFiveCnt = 0;

    for(int i = 0 ; i < 10; i++)
    {
        if(arr[i] % 3 == 0)
        {
            mulOfThreeCnt++;
        }
        if(arr[i] % 5 == 0)
        {
            mulOfFiveCnt++;
        }
    }

    cout << mulOfThreeCnt << " " << mulOfFiveCnt;
    
    return 0;
}
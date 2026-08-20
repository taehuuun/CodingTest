#include <iostream>
#include <climits>

using namespace std;

int main() 
{
    const int MAX_SIZE = 100;
    int n, k, arr[MAX_SIZE] = {}, max = INT_MIN;

    cin >> n >> k;

    for(int i = 0; i < k; i++)
    {
        int start, end;

        cin >> start >> end;

        for(int j = start-1; j < end; j++)
        {
            arr[j]++;
        }
    }

    for(int i = 0; i <n ; i++)
    {
        if(max < arr[i])
        {
            max = arr[i];
        }
    }

    cout << max;

    return 0;
}
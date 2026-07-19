#include <iostream>
#include <climits>
using namespace std;

int main() 
{
    const int MAX_SIZE = 100;
    int n, input, min = INT_MAX, count = 0, arr[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> input;

        arr[i] = input;

        if(input < min)
        {
            min = input;
        }
    }

    for(int i = 0; i < n; i++)
    {
        if(arr[i] == min)
        {
            count++;
        }
    }

    cout << min << " " << count;

    return 0;
}
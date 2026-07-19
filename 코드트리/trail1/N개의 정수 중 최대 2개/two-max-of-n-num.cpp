#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 100;
    int n, arr[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = 0 ; i < n; i++)
    {
        for(int j = i+1; j < n; j++)
        {
            if(arr[i] < arr[j])
            {
                int tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
    }

    cout << arr[0] << " " << arr[1];

    return 0;
}
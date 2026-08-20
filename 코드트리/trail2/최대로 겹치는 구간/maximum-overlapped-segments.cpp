#include <iostream>
using namespace std;

int main() 
{
    const int MAX_SIZE = 201;
    int n, arr[MAX_SIZE] = {}, max = -999;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int x1, x2;
        cin >> x1 >> x2;

        x1 += 100;
        x2 += 100;

        for(int i = x1; i < x2; i++)
        {
            arr[i]++;

            if(max < arr[i])
            {
                max = arr[i];
            }
        }
    }

    cout << max;

    return 0;
}
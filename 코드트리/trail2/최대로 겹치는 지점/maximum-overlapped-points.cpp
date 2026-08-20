#include <iostream>
using namespace std;

int main() 
{
    int n, arr[101] = {}, max = -999;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int x1, x2;

        cin >> x1 >> x2;

        for(int i = x1; i <=x2; i++)
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
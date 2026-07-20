#include <iostream>
#include <climits>
using namespace std;

int main() 
{
    const int MAX_SIZE = 1001;
    int n, arr[MAX_SIZE], maxPrice = INT_MIN;

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = 0; i < n; i++)
    {
        for(int j = i + 1; j < n; j++)
        {
            int price = arr[j] - arr[i];

            if(maxPrice < price)
            {
                maxPrice = price;
            }
        }
    }

    cout << (maxPrice > 0 ? maxPrice : 0);

    return 0;
}
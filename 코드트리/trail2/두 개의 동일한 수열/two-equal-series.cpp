#include <iostream>
#include <algorithm>

using namespace std;

const int MAX_SIZE = 100;

int main() 
{
    bool isSame = true;
    int n, arr1[MAX_SIZE], arr2[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr1[i];
    }

    for(int i = 0; i < n; i++)
    {
        cin >> arr2[i];
    }

    sort(arr1, arr1 + n);
    sort(arr2, arr2 + n);

    for(int i = 0; i < n; i++)
    {
        if(arr1[i] != arr2[i])
        {
            isSame = false;
            break;
        }
    }

    cout << (isSame ? "Yes" : "No");

    return 0;
}
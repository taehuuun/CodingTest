#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

const int MAX_SIZE = 100;

int main() 
{
    int n;
    string arr[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    sort(arr, arr + n);

    for(int i = 0; i < n; i++)
    {
        cout << arr[i] << endl;
    }

    return 0;
}
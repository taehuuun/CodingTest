#include <iostream>
#include <string>

using namespace std;

int main() 
{
    const int MAX_SIZE = 10;
    string arr[MAX_SIZE];
    int n, sum = 0, count = 0;

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
        sum += arr[i].length();
    }

    for(int i = 0 ; i < n; i++)
    {
        if(arr[i][0] != 'a')
        {
            continue;
        }

        count++;
    }

    cout << sum << " " << count;

    return 0;
}
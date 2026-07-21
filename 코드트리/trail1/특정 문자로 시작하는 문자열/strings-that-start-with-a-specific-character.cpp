#include <iostream>
#include <string>

using namespace std;

int main() 
{
    const int MAX_SIZE = 20;

    int n, count = 0, sum = 0;
    string arr[MAX_SIZE];
    char target;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    cin >> target;

    for(int i = 0; i < n; i++)
    {
        if(arr[i][0] == target)
        {
            count++;
            sum += arr[i].length();
        }
    }

    cout << count << " ";

    cout << fixed;
    cout.precision(2);

    cout << (float)sum / count;

    return 0;
}
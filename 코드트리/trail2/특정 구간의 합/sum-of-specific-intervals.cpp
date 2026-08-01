#include <iostream>
using namespace std;

const int MAX_SIZE = 100;
int arr[MAX_SIZE] = { };

int main() 
{
    int n, m;

    cin >> n >> m;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = 0; i < m; i++)
    {
        int start, end, sum = 0;

        cin >> start >> end;

        for(int j = start; j <= end; j++)
        {
            sum += arr[j-1];
        }

        cout << sum << endl;
    }

    return 0;
}
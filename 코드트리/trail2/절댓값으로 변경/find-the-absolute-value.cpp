#include <iostream>
#include <string>

using namespace std;

void ChangeAbsolute(int *n, int len)
{
    for(int i = 0; i < len; i++)
    {
        string tmp = to_string(n[i]);

        if(tmp[0] == '-')
        {
            tmp = tmp.erase(0,1);
        }

        n[i] = stoi(tmp);
    }
}

int main() 
{
    const int MAX_SIZE = 50;
    int n, arr[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }

    ChangeAbsolute(arr, n);

    for(int i = 0; i < n; i++)
    {
        cout << arr[i] << ' ';
    }

    return 0;
}
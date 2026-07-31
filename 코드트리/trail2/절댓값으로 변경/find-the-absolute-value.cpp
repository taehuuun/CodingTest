#include <iostream>
#include <string>

using namespace std;

int GetAbsolute(int n)
{
    string tmp = to_string(n);

    if(tmp[0] == '-')
    {
        tmp = tmp.erase(0,1);
    }

    return stoi(tmp);
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

    for(int i = 0; i < n; i++)
    {
        cout << GetAbsolute(arr[i]) << ' ';
    }

    return 0;
}
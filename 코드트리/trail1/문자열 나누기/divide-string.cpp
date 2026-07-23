#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input, result;
    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> input;

        result += input;
    }

    for(int i = 0; i < result.length(); i++)
    {
        cout << result[i];

        if((i+1) % 5 == 0)
        {
            cout << '\n';
        }
    }

    return 0;
}
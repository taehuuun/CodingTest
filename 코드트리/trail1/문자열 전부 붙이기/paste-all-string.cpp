#include <iostream>
#include <string>

using namespace std;

int main() 
{
    int n;
    string input, result;

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        cin >> input;

        result += input;
    }

    cout << result;

    return 0;
}
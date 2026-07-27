#include <iostream>
#include <string>

using namespace std;

int main() 
{
    int n, input, sum = 0;
    string result;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> input;

        sum += input;
    }

    string tmp = to_string(sum);
    result = tmp.substr(1, tmp.length() -1) + tmp.substr(0,1);

    cout << result;

    return 0;
}
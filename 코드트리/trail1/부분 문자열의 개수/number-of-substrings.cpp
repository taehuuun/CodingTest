#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input, target;
    int cnt = 0;

    cin >> input >> target;

    for(int i = 0; i < input.length(); i++)
    {
        if(input.substr(i,target.length()) == target)
        {
            cnt++;
        }
    }

    cout << cnt;

    return 0;
}
#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    int removeIdx = 0;

    cin >> input;

    while(input.length() > 1)
    {
        cin >> removeIdx;

        removeIdx = removeIdx >= input.length() ? input.length()-1 : removeIdx;

        input.erase(removeIdx, 1);

        cout << input << endl;
    }

    return 0;
}
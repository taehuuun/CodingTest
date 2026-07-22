#include <iostream>
#include <string>

using namespace std;

int main()
{
    string input, result;
    int len = 0, index = 0;

    cin >> input;

    len = input.length();

    while(index <= len-1)
    {
        char target = input[index];
        int count = 1;

        result += target;

        for(int i = index; i < input.length(); i++)
        {
            char current = input[i + 1];
            if(current != target)
            {
                result += to_string(count);
                index = i + 1;
                break;
            }

            count++;
        }
    }

    cout << result.length() << endl;
    cout << result;

    return 0;
}
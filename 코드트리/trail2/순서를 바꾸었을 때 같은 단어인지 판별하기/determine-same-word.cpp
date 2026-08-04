#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main() 
{
    bool isSame = true;
    string input1, input2;

    cin >> input1 >> input2;

    sort(input1.begin(), input1.end());
    sort(input2.begin(), input2.end());

    if(input1.length() == input2.length())
    {
        for(int i = 0 ; i < input1.length(); i++)
        {
            if(input1[i] != input2[i])
            {
                isSame = false;
                break;
            }
        }

        cout << (isSame ? "Yes" : "No");
    }
    else
    {
        cout << "No";
    }

    return 0;
}
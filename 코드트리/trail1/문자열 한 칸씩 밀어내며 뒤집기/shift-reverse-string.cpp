#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    int q, len = 0;

    cin >> input >> q;

    len = input.length();

    for(int i = 0; i < q; i++)
    {
        int request;

        cin >> request;

        if(request == 1)
        {
            input = input.substr(1, len -1) + input.substr(0, 1);
        }
        else if(request == 2)
        {
            input = input.substr(len-1, 1) + input.substr(0, len-1);
        }
        else if(request == 3)
        {
            string tmp = "";

            for(int j = len-1 ; j >= 0; j--)
            {
                tmp += input[j];
            }

            input = tmp;
        }

        cout << input << endl;
    }

    return 0;
}
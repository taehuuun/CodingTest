#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;
    int q;

    cin >> input >> q;

    for(int i = 0 ; i < q; i++)
    {
        int menu;

        cin >> menu;

        if(menu == 1)
        {
            int a, b;

            cin >> a >> b;

            char tmp = input[a - 1];
            input[a-1] = input[b - 1];
            input[b-1] = tmp;
        }
        else
        {
            char x, y;

            cin >> x >> y;

            for(int j = 0 ; j < input.length(); j++)
            {
                if(input[j] == x)
                {
                    input[j] = y;
                }
            }
        }

        cout << input << endl;
    }

    return 0;
}

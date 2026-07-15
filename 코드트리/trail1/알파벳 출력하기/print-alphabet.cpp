#include <iostream>
using namespace std;

int main() 
{
    int n, ascii = 65;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < i + 1; j++)
        {
            cout << (char)ascii;

            ascii++;

            if(ascii > (int)'Z')
            {
                ascii = (int)'A';
            }
        }

        cout << endl;
    }

    return 0;
}
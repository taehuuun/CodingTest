#include <iostream>
using namespace std;

int main() 
{
    int n, num = 1;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < i; j++)
        {
            cout << "  ";
        }

        for(int j = n - i; j > 0; j--)
        {
            cout << num << " ";
            num++;

            if(num > 9)
            {
                num = 1;
            }
        }

        cout << endl;
    }

    return 0;
}
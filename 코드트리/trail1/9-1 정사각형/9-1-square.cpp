#include <iostream>
using namespace std;

int main() 
{
    int n, num = 9;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            cout << num;
            num--;

            if(num == 0)
            {
                num = 9;
            }
        }

        cout << endl;
    }

    return 0;
}
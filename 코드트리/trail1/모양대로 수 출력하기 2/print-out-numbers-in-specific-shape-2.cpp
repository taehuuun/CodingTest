#include <iostream>
using namespace std;

int main() 
{
    int n, num = 0;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            num += 2;

            if(num >= 10)
            {
                num = 2;
            }
            cout << num << " ";
        }

        cout << endl;
    }

    return 0;
}
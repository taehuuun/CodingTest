#include <iostream>
using namespace std;

int main() 
{
    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        int a, b, sum = 0;

        cin >> a >> b;

        for(int num = a; num <= b; num++)
        {
            if(num % 2 == 0)
            {
                sum += num;
            }
        }

        cout << sum << endl;
    }

    return 0;
}
#include <iostream>
using namespace std;

int main() 
{
    char fruits[5][20] = { {"apple"}, {"banana"}, {"grape"}, {"blueberry"}, {"orange"}};
    char target;
    int count = 0;

    cin >> target;

    for(int i = 0 ; i < 5; i++)
    {
        if(fruits[i][2] == target || fruits[i][3] == target)
        {
            count++;
            for(int j = 0 ; j < sizeof(fruits[i]); j++)
            {
                if(fruits[i][j] == '\0')
                {
                    break;
                }
                cout << fruits[i][j];
            }

            cout << endl;
        }
    }

    cout << count;

    return 0;
}
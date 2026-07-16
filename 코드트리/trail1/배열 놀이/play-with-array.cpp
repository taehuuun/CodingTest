#include <iostream>
using namespace std;

int main()
{
    const int MAX_ELEMENT_COUNT = 101;
    int n, q, arr[MAX_ELEMENT_COUNT];

    cin >> n >> q;

    for(int i = 0 ; i < n; i++)
    {
        cin >> arr[i];
    }

    for(int i = 0; i < q; i++)
    {
        int question, param1, param2;

        cin >> question;

        if(question == 1)
        {
            cin >> param1;

            cout << arr[param1-1];
        }
        else if(question == 2)
        {
            cin >> param1;

            int findIdx = 0;

            for(int j = 0 ; j < n; j++)
            {
                if(arr[j] == param1)
                {
                    findIdx = j + 1;
                    break;
                }
            }

            cout << findIdx;
        }
        else
        {
            cin >> param1 >> param2;

            for(int j = param1-1; j <= param2-1; j++)
            {
                cout << arr[j] << " ";
            }
        }

        cout << endl;
    }

    return 0;
}
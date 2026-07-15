#include <iostream>
using namespace std;

int main() 
{
    int n;
    float sum = 0;

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        float input;

        cin >> input;

        sum += input;
    }

    float avg = sum / n;
    cout << fixed;
    cout.precision(1);

    cout << avg << endl;

    if(avg >= 4.0f)
    {
        cout << "Perfect";
    }
    else if(avg >= 3.0f)
    {
        cout << "Good";
    }
    else
    {
        cout << "Poor";
    }

    return 0;
}
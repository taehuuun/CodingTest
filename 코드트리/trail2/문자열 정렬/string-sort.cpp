#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    sort(input.begin(), input.end());

    cout << input;

    return 0;
}
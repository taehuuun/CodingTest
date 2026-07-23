#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    cout << (input.find("ee") != string::npos ? "Yes" : "No");
    cout << " ";
    cout << (input.find("ab") != string::npos ? "Yes" : "No");

    return 0;
}
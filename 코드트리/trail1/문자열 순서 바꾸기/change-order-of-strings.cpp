#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string s, t;

    cin >> s >> t;

    string tmp = s;
    s = t;
    t = tmp;

    cout << s << endl;
    cout << t;

    return 0;
}
#include <iostream>
#include <string>

using namespace std;

int N;

string ans = "";
int first[26];

int main()
{

    cin >> N;

    for(int i = 0 ; i< N; i++)
    {
        string tmp;

        cin >>tmp;
        first[(int)tmp[0]-97]++;
    }

    for(int i = 0 ;i <26; i++)
    {
        if(first[i] >= 5)
            ans += (char)i+97;
    }

    if(ans.size() > 0)
        cout << ans;
    else
        cout  << "PREDAJA";

    return 0;
}

#include <iostream>
#include <stack>

using namespace std;

bool CheckStr(string str)
{
  stack<char> par;

  for(int i = 0; i<str.size(); i++)
  {
    if(str[i] == '(')
      par.push(str[i]);
    else
      {
        if(!par.empty())
          par.pop();
        else
          return false;
      }
  }

  return par.empty();
}

int main()
{
  int t;

  cin >> t;

  for(int i = 0; i<t; i++)
  {
    string tmp;
    cin >> tmp;

    if(CheckStr(tmp))
      cout << "YES" << endl;
    else
      cout << "NO" << endl;
  }


  return 0;
}

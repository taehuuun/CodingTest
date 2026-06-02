#include <string>
#include <vector>

using namespace std;

vector<int> solution(int l, int r) 
{
    vector<int> answer;
    
    for(int i = l; i <= r; i++)
    {
        string str = to_string(i);
        
        bool find = true;
        
        for(int j = 0; j <str.length(); j++)
        {
            if(str[j] != '0' && str[j] != '5')
            {
                find = false;
                continue;
            }
            
        }
        
        if(find)
        {
            answer.push_back(i);
        }
    }
    
    if(answer.size() == 0)
    {
        answer.push_back(-1);
    }
    
    return answer;
}
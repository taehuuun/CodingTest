#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr, vector<vector<int>> queries) 
{
    vector<int> answer;
    
    answer = arr;
    
    for(int q = 0; q < queries.size(); q++)
    {
        int start = queries[q][0];
        int end = queries[q][1];
        int k = queries[q][2];
        
        for(int i = start; i <= end; i++)
        {
            if(i % k == 0)
            {
                answer[i]++;
            }
        }
    }
    
    return answer;
}
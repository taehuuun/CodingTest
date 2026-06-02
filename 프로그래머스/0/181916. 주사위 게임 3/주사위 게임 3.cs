using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int a, int b, int c, int d) 
    {
        int answer = 0;
        
        Dictionary<int, int> dict = new  Dictionary<int, int>();
        
        for(int i = 1; i <= 6; i++)
        {
            dict.Add(i,0);
        }
        
        dict[a]++;
        dict[b]++;
        dict[c]++;
        dict[d]++;
    
        List<int> diff = new List<int>();
        
        foreach(int key in dict.Keys)
        {
            if(dict[key] > 0)
            {
                diff.Add(key);
            }
        }
        
        if(diff.Count == 1)
        {
            answer = 1111 * diff[0];
        }
        else if(diff.Count == 2)
        {
            if(dict[diff[0]] == dict[diff[1]])
            {
                answer = (diff[0] + diff[1]) * (Math.Abs(diff[1] - diff[0]));
            }
            else
            {
                int p = dict[diff[0]] > dict[diff[1]] ? diff[0] : diff[1];
                int q = dict[diff[0]] > dict[diff[1]] ? diff[1] : diff[0];
                
                answer = (int)Math.Pow(10*p+q,2);
            }
        }
        else if(diff.Count == 3)
        {
            int p = 0;
            List<int> tmp = new List<int>();
            foreach(int key in dict.Keys)
            {
                if(dict[key] == 2)
                {
                    p = key;
                    break;
                }
            }
            
            for(int i = 0 ; i < diff.Count; i++)
            {
                if(diff[i] != p)
                {
                    tmp.Add(diff[i]);
                }
            }
            
            answer = tmp[0] * tmp[1];
        }
        else
        {
            diff.Sort();
            answer = diff[0];
        }
        
        return answer;
    }
}
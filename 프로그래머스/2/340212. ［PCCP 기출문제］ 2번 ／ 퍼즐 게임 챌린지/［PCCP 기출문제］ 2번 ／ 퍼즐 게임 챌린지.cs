using System;
using System.Linq;

public class Solution
{
    public bool IsClear(ref int[] diffs, ref int[] times, long limit, int level)
    {
        limit -= times[0];
        
        for(int i = 1; i < diffs.Length; i++)
        {
            limit -= times[i];
            int count = diffs[i] - level;
            
            if(count > 0)
                limit -= count * (times[i - 1] + times[i]);
            
            if(limit < 0)
                return false;
        }
        
        return true;
    }
    
    public int solution(int[] diffs, int[] times, long limit)
    {
        int left = 1;
        int right = diffs.Max();
        
        while(left <= right)
        {
            int mid = (left + right) / 2;
            
            if(IsClear(ref diffs, ref times, limit, mid))
                right = mid - 1;
            else
                left = mid + 1;
        }
        
        return left;
    }
}
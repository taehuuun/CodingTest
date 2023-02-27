using System;

public class Solution 
{
    public long solution(string t, string p) 
    {
        long answer = 0;
        long splitLen = t.Length - p.Length + 1;
        // splitLen(t의 길이 - p의 길이) 만큼 반복
        for(long i = 0; i < splitLen; i++)
        {
            // i부터 p의 길이 만큼 나눈다.
            string splitNum = t.Substring((int)i,p.Length);
            
            // splitNum과 p를 각각 정수로 변환하여 비교한뒤, p가 크거나 같다면
            // 카운트를 증가한다.
            if (long.Parse(p) >= long.Parse(splitNum))
            {
                answer++;
            }
        }
        
        return answer;
    }
}

using System;

public class Solution 
{
    public int solution(int[] common) 
    {
        int answer = 0;
        
        answer = CheckSequence(common);
        
        return answer;
    }
    
    // 수열을 체크하고 다음에 올수를 리턴하는 함수
    public int CheckSequence(int[] common)
    {
        // 수열의 길이가 고정이므로 간단히 항의 차이를 구하여
        // 각 항의 차이가 같다면 등차수열 아니라면 등비 수열이다
        // 등차는 공차를 구하고, 등비는 공비를 구하여 수열의 마지막 값에
        // 공차(공비)를 더해 다음수를 리턴한다
        if(common[2] - common[1] == common[1] - common[0])
        {
            int commonDif = common[1] - common[0];
            return common[common.Length -1] + commonDif;
        }
        else
        {
            int commonRatio = common[1] / common[0];
            return common[common.Length -1] * commonRatio;
        }
    }
}
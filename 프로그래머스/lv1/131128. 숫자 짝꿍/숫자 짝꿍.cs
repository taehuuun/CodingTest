using System;
using System.Text;
using System.Linq;

public class Solution 
{
    public string solution(string X, string Y) 
    {
        string answer = FindCommonPairs(X,Y);
        
        return answer;
    }
    
    // 공통 문자들을 찾아 문자열을 리턴시키는 함수
    string FindCommonPairs(string str1, string str2)
    {
        // str1 문자열의 0~9까지 숫자의 빈도수를 저장할 배열
        int[] cnt1 = new int [10];
        
        // str2 문자열의 0~9까지 숫자의 빈도수를 저장할 배열
        int[] cnt2 = new int [10];
        
        // str1 문자열의 문자 값에 해당하는 배열에 카운트를 증가 시킨다
        foreach (var c in str1)
        {
            cnt1[c - '0']++;
        }
        
        // str2 문자열의 문자 값에 해당하는 배열에 카운트를 증가 시킨다
        foreach (var c in str2)
        {
            cnt2[c - '0']++;
        }
        
        // 결과를 담을 StringBuilder를 생성한다
        StringBuilder result = new StringBuilder();
        
        // 공통된 문자가 있는지 체크 한다
        bool hasCommonPairs = false;
        
        // 9 부터 0까지 (10번 반복)
        for (int i = 9; i >= 0; i--)
        {
            // cnt1, cnt2의 i번째 빈도수중 가장 작은 값을 대입
            int commonCnt = Math.Min(cnt1[i], cnt2[i]);
            
            // i번째 빈도수가 0 이상이라면 hasCommonPairs를 true로 변경
            if(commonCnt > 0)
            {
                hasCommonPairs = true;
            }
            
            // result 문자열에 해당하는 값을 추가
            result.Append(new string((char)(i + '0'), commonCnt));
        }
        
        // 공통된 문자가 하나도 없을 경우 -1 리턴
        if(!hasCommonPairs)
        {
            return "-1";
        }
        
        // reusltStr에 StringBuilder를 문자열로 만들어 대입
        string resultStr = result.ToString();
        
        // resultStr가 0으로만 이루어져 있으면 0만 리턴, 아니라면 resultStr를 리턴
        return resultStr.All(c => c == '0') ? "0" : resultStr;
    }
}
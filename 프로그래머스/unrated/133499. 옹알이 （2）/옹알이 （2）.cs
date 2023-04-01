using System;
using System.Text.RegularExpressions;

public class Solution 
{
    public int solution(string[] babbling) 
    {
        // 발음 할 수 있는 문자열 배열
        string[] keywords = { "aya", "ye", "woo", "ma" };

        int answer = 0;

        // babbling 배열의 각 문자열을 순회하며 발음 가능한 단어를 찾습니다.
        foreach (string babble in babbling)
        {
            // 발음 가능한 문자열을 숫자로 치환합니다.
            string replacedBabble = ReplaceKeywords(keywords, babble);

            // 치환된 문자열이 숫자로만 구성되어 있고 연속되지 않는지 확인합니다.
            if (Regex.IsMatch(replacedBabble, "^[0-9]*$") && IsContinuous(replacedBabble))
            {
                // 조건에 맞으면 정답 카운터를 증가시킵니다.
                answer++;
            }
        }

        return answer;
    }

    // 키워드를 해당 인덱스 값으로 치환하는 메서드입니다.
    string ReplaceKeywords(string[] keywords, string babble)
    {
        for (int i = 0; i < keywords.Length; i++)
        {
            babble = babble.Replace(keywords[i], i.ToString());
        }
        return babble;
    }

    // 문자열이 연속되지 않는지 확인하는 메서드입니다.
    bool IsContinuous(string babble)
    {
        for (int i = 0; i < babble.Length - 1; i++)
        {
            if (babble[i] == babble[i + 1])
            {
                // 연속되는 문자가 발견되면 false를 반환합니다.
                return false;
            }
        }
        // 문자열 내에 연속되는 문자가 없으면 true를 반환합니다.
        return true;
    }

}
using System;

public class Solution 
{
    public string solution(string my_string, int[,] queries) 
    {
        string answer = "";
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int start = queries[i,0];
            int count = queries[i,1]  - queries[i,0] + 1;
            my_string = Reverse(my_string, start, count);
        }
            
        return my_string;
    }
    
    public string Reverse(string str, int start, int count)
    {
        string target = str.Substring(start, count); // "lloWo"

        // 2. 문자 배열로 변환하여 역순 정렬
        char[] charArray = target.ToCharArray();
        Array.Reverse(charArray);
        string reversedPart = new string(charArray); // "oWoll"

        // 3. 기존 문자열과 결합
        return str.Substring(0, start) + reversedPart + str.Substring(start + count);
    }
}
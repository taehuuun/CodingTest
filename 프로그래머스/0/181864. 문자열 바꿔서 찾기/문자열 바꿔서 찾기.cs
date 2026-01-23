using System;

public class Solution 
{
    public int solution(string myString, string pat) 
    {
        int answer = 0;
        var reverseStr = "";
        
        foreach(var c in myString)
        {
            reverseStr += c == 'A' ? 'B' : 'A';
        }
        
        return reverseStr.Contains(pat) ? 1 : 0;
    }
}
using System;

public class Solution {
    public int solution(string binomial) 
    {
        int answer = 0;
        
        string[] split = binomial.Split(' ');
        int a = int.Parse(split[0]);
        string op = split[1];
        int b = int.Parse(split[2]);
        
        switch(op)
        {
            case "+":
                answer = a + b;
                break;
            case "-":
                answer = a - b;
                break;
            case "*":
                answer = a * b;
                break;
        }
        
        return answer;
    }
}
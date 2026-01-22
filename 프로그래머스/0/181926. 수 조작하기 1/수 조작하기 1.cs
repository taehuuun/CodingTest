using System;

public class Solution 
{
    public int solution(int n, string control) 
    {
        // int answer = n;
        
        for(int i = 0; i < control.Length; i++)
        {
            switch (control[i])
            {
                case 'w':
                    n += 1;
                    break;
                case 's':
                    n -= 1;
                    break;
                case 'd':
                    n += 10;
                    break;
                case 'a':
                    n -= 10;
                    break;
            }
        }
        
        return n;
    }
}
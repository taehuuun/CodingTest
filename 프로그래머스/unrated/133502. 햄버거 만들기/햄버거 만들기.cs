using System;
using System.Text;

public class Solution 
{
    public int solution(int[] ingredient)
    {
        int answer = 0;

        StringBuilder build = new StringBuilder();

        for (int i = 0; i < ingredient.Length; i++)
        {
            build.Append(ingredient[i]);
            
            if (build.Length > 3 && build.ToString(build.Length - 4, 4).Equals("1231"))
            {
                answer++;
                build.Remove(build.Length - 4, 4);
            }
        }

        return answer;
    }
}
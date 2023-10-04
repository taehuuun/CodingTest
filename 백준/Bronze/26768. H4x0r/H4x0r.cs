using System.Text;

string input = Console.ReadLine();
StringBuilder sb = new StringBuilder();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'a')
    {
        sb.Append('4');
    }
    else if (input[i] == '4')
    {
        sb.Append('a');
    }
    else if (input[i] == 'e')
    {
        sb.Append('3');
    }
    else if (input[i] == '3')
    {
        sb.Append('e');
    }
    else if (input[i] == 'i')
    {
        sb.Append('1');
    }
    else if (input[i] == '1')
    {
        sb.Append('i');
    }
    else if (input[i] == 'o')
    {
        sb.Append('0');
    }
    else if (input[i] == '0')
    {
        sb.Append('o');
    }
    else if (input[i] == 's')
    {
        sb.Append('5');
    }
    else if (input[i] == '5')
    {
        sb.Append('s');
    }
    else
    {
        sb.Append(input[i]);
    }
}

Console.WriteLine(sb);
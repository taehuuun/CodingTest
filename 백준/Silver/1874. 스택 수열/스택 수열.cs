using System.Text;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
int cur = 1;
Stack<int> stack = new Stack<int>();
StringBuilder sb = new StringBuilder();
int check = 0;
for(int i = 0; i < n; i++){
    int input = int.Parse(sr.ReadLine());
    while(cur <= input){
        stack.Push(cur);
        cur++;
        sb.AppendLine("+");
    }
    if(stack.Peek() == input){
        stack.Pop();
        sb.AppendLine("-");
    }
    else{
        check = 1;
    }
}
if(check == 1){
    sw.WriteLine("NO");
}
else{
    sw.WriteLine(sb);
}
sr.Close();
sw.Close();
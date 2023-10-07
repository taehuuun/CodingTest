using System.Text;

var sb = new StringBuilder();

var n = int.Parse(Console.ReadLine()!);

var photos = new List<string>();
for (int i = 0; i < n; i++)
    photos.Add(Console.ReadLine()!);

var m = int.Parse(Console.ReadLine()!);
for (int i = 0; i < m; i++) {
    var input = Console.ReadLine()!.Split(' ');
    var l = int.Parse(input[0]);
    var r = int.Parse(input[1]);

    for (int j = l - 1; j < r; j++)
        sb.AppendLine(photos[j]);
}

Console.Write(sb.ToString());
float totalRatingSum = 0f;
float totalCreditSum = 0f;

for (int i = 0; i < 20; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    float subjectScore = 0f;

    switch (input[2])
    {
        case "A+":
            subjectScore = 4.5f;
            break;
        case "A0":
            subjectScore = 4.0f;
            break;
        case "B+":
            subjectScore = 3.5f;
            break;
        case "B0":
            subjectScore = 3.0f;
            break;
        case "C+":
            subjectScore = 2.5f;
            break;
        case "C0":
            subjectScore = 2.0f;
            break;
        case "D+":
            subjectScore = 1.5f;
            break;
        case "D0":
            subjectScore = 1.0f;
            break;
        default:
            if(input[2] == "P")
                continue;
            
            subjectScore = 0f;
            break;
    }

    totalCreditSum += float.Parse(input[1]);
    totalRatingSum += float.Parse(input[1]) * subjectScore;
}

float avgRating = totalRatingSum/totalCreditSum;
Console.WriteLine($"{avgRating:0.000000}");
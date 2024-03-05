string[] arrayStr = new string[] {"Hello", "2", "world", ":-)"};

int count = 0;
foreach (string element in arrayStr)
{
    if (element.Length <= 3)
    {
        count++;
    }
}

string[] newArrStr = new string[count];

if (count > 0)
{
    int j = 0;
    foreach (string element in arrayStr)
    {
        if (element.Length <= 3)
        {
            newArrStr[j] = element;
            j++;
        }
    }
}

Console.WriteLine($"[{string.Join(", ", arrayStr)}] -> [{string.Join(", ", newArrStr)}]");
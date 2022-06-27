// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Program.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

var data = GetUserInput();
TryGetNumberFromString(data);

string GetUserInput()
{
    Console.WriteLine("Enter set of numbers separated by space");
    return Console.ReadLine().Trim();
}

void TryGetNumberFromString(string data)
{
    if (string.IsNullOrWhiteSpace(data))
    {
        Console.WriteLine("Wrong data");
        return;
    }

    var sum = 0.0;
    var temp = string.Empty;
    for (var i = 0; i < data.Length; i++)
    {
        if (data[i] != ' ')
        {
            temp += data[i];
            continue;
        }

        if (IsAllDigits(temp)) sum += double.Parse(temp);

        temp = string.Empty;
    }

    if (IsAllDigits(temp)) sum += double.Parse(temp);
    Console.WriteLine($"Sum of numbers {data} is {sum}");
}

bool IsAllDigits(string s)
{
    for (var index = 0; index < s.Length; index++)
        if (!char.IsDigit(s[index]))
            return false;

    return true;
}
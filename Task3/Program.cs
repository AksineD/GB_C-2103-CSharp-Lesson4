// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The seasons.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

int GetUserInput()
{
    if (int.TryParse(Console.ReadLine(), out var result))
        if (result >= 1 && result <= 12)
            return result;

    Console.WriteLine("Error: Please enter a number from 1 to 12");

    return GetUserInput();
}

Console.WriteLine("Please enter a month number");
var monthNum = GetUserInput();

var season = GetSeason(monthNum);
var str = TranslateSeason(season);
Console.WriteLine(str);

Seasons GetSeason(int month)
{
    if (month == 1 || month == 2 || month == 12) return Seasons.Winter;
    if (month == 3 || month == 4 || month == 5) return Seasons.Spring;
    if (month == 6 || month == 7 || month == 8) return Seasons.Summer;

    return Seasons.Autumn;
}

string TranslateSeason(Seasons val)
{
    switch (val)
    {
        case Seasons.Winter:
            {
                return "зима";
            }

        case Seasons.Spring:
            {
                return "весна";
            }

        case Seasons.Summer:
            {
                return "лето";
            }

        default: return "осень";
    }
}

/// <summary>
/// The seasons.
/// </summary>
internal enum Seasons
{
    /// <summary>
    /// The winter.
    /// </summary>
    Winter = 1,

    /// <summary>
    /// The spring.
    /// </summary>
    Spring,

    /// <summary>
    /// The summer.
    /// </summary>
    Summer,

    /// <summary>
    /// The autumn.
    /// </summary>
    Autumn
}
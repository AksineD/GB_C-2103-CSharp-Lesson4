// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Program.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

Console.WriteLine(GetFullName("Ivan", "Ivanov", "Ivanovich"));
Console.WriteLine(GetFullName("Petr", "Petrov", "Petrovich"));
Console.WriteLine(GetFullName("Boris", "Borisov", "Borisovich"));
Console.WriteLine(GetFullName("Vasiliy", "Vasilev", "Valilevich"));

string GetFullName(string firstName, string lastName, string patronymic)
{
    return $"{firstName} {lastName} {patronymic}";
}
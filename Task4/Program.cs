// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Program.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

Console.WriteLine("Please enter a number");
var numOfItems = GetUserInput();

var res = Fibonacci(numOfItems);

Console.WriteLine(res);

int GetUserInput()
{
    if (int.TryParse(Console.ReadLine(), out var result))
        if (result > 0)
            return result;
    Console.WriteLine("Please enter a correct number greater than 0");

    return GetUserInput();
}

int Fibonacci(int n1)
{
    if (n1 <= 2) return 1;

    return Fibonacci(n1 - 1) + Fibonacci(n1 - 2);
}
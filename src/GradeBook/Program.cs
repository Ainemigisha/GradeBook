// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;



var book = new Book("Picfare");


while (true)
{
    Console.WriteLine("Please enter a grade");
    var input = Console.ReadLine();
    if (input == null)
        continue;
    if (input == "q")
        break;

    try
    {
        book.AddGrade(double.Parse(input));
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }


}

var stats = book.GetStatistics();


Console.WriteLine($"Average Grade is {stats.Average:N1}");
Console.WriteLine($"Highest Grade is {stats.High}");
Console.WriteLine($"Lowest Grade is {stats.Low}");
Console.WriteLine($"Average Grade Letter is {stats.Letter}");


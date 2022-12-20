// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

var numbers = new[] { 12.4, 34.4, 98.2, 24.2 };
var result = 0.0;
var grades = new List<double>() { 1.2, 20, 1, 10.2 };
grades.Add(2.0);
var avg = 0.0;

foreach (var number in grades)
{
    result += number;
}
result /= grades.Count;

Console.WriteLine($"Average is {result:N1}");
Console.WriteLine(avg);

if (args.Length > 0)
    Console.WriteLine($"Hello, {args[0]}!");
else
    Console.WriteLine("Hello Alvin");



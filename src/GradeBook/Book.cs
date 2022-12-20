class Book
{
    public Book(string name)
    {
        grades = new List<double>();
        this.name = name;
    }
    public void AddGrade(double grade)
    {
        grades.Add(grade);
    }

    public void ShowStatistics()
    {

        foreach (var number in grades)
        {
            highGrade = Math.Max(number, highGrade);
            lowGrade = Math.Min(number, lowGrade);

            result += number;
        }
        averageGrade = result / grades.Count;

        Console.WriteLine($"Average Grade is {result:N1}");
        Console.WriteLine($"Highest Grade is {highGrade}");
        Console.WriteLine($"Lowest value is {lowGrade}");

    }

    List<double> grades;
    string name;
    double highGrade = double.MinValue;
    double lowGrade = double.MaxValue;
    double result = 0.0, averageGrade;
}


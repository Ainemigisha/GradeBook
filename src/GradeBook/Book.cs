public class Book
{
    public Book(string name)
    {
        grades = new List<double>();
        Name = name;
    }

    public void AddLetterGrade(char letter)
    {

    }

    public void AddGrade(double grade)
    {
        if (grade <= 100 && grade >= 0)
            grades.Add(grade);
        else
            throw new ArgumentException($"Invalid {nameof(grade)}");
    }

    public Statistics GetStatistics()
    {
        var result = new Statistics();
        result.Average = 0.0;
        result.High = double.MinValue;
        result.Low = double.MaxValue;

        foreach (var grade in grades)
        {
            result.High = Math.Max(grade, result.High);
            result.Low = Math.Min(grade, result.High);

            result.Average += grade;
        }
        result.Average /= grades.Count;

        switch (result.Average)
        {
            case var d when d >= 90.0:
                result.Letter = 'A';
                break;
            case var d when d >= 80.0:
                result.Letter = 'B';
                break;
            case var d when d >= 70.0:
                result.Letter = 'C';
                break;
            case var d when d >= 60.0:
                result.Letter = 'D';
                break;
            default:
                result.Letter = 'F';
                break;
        }

        return result;

    }

    List<double> grades;
    public string Name;

}


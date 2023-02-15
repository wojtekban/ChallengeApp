using ChallengeApp;

var employee = new Employee("Adam", "Wilczewski", 46);
employee.AddGrade("2");
employee.AddGrade(4);
employee.AddGrade(15.50);
employee.AddGrade(22L);
employee.AddGrade(14d);
employee.AddGrade(99);
employee.AddGrade(2.20E+23);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

void SetSth(out Statistics statisics)
{
    statisics = new Statistics();

}


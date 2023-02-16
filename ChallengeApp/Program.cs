using ChallengeApp;

var employee = new Employee("Adam", "Wilczewski", 46);
employee.AddGrade("2");
employee.AddGrade("Wiktor");
employee.AddGrade(15.50);
employee.AddGrade(22L);
employee.AddGrade(14);
employee.AddGrade(99);
employee.AddGrade(2.20E+23);

Console.WriteLine("Wynik dla ForEach = ");
var statistics = employee.GetStatisticsForEach();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("Wynik dla For = ");
var statistics1 = employee.GetStatisticsFor();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("Wynik dla DoWhile = ");
var statistics2 = employee.GetStatisticsDoWhile();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine("Wynik dla While = ");
var statistics3 = employee.GetStatisticsWhile();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

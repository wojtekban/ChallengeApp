using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new Employee("Wacek", "Wackowski", 44);

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}


var statistics = employee.GetStatistics();
Console.WriteLine($"Averange Letter: {statistics.AverageLetter}");
Console.WriteLine($"Averange: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
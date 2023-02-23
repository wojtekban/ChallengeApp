using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Wacek", "Wackowski", 44);
employee.GradeAdded += EmployeeGradeAdded;

    void EmployeeGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Dodano nową ocenę pracownika");
        }

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"Exception catched {ex.Message}");
    }
    
}

var statistics = employee.GetStatistics();

Console.WriteLine($"PRACOWNIK: {employee.Name} {employee.SurName} {employee.Age}");
Console.WriteLine($"Averange Letter: {statistics.AverageLetter}");
Console.WriteLine($"Averange: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
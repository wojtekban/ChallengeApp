using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("============================================");
Console.WriteLine();

//var supervisor = new Supervisor("Iza", "Tokarska", 24);
var employee = new EmployeeInFile("Wacek", "Wackowski", 44);

//while (true)
//{
 //   Console.WriteLine("Podaj kolejną ocenę kierownika: ");
 //   var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
  //  try
//    {
 //       supervisor.AddGrade(input);
 //   }
//    catch (Exception ex)
 //   {
 //       Console.WriteLine($"Exception catched {ex.Message}");
//    }

//}


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
//var statisticsSupervisor = supervisor.GetStatistics();
//Console.WriteLine($"KIEROWNIK: {supervisor.Name} { supervisor.SurName} {supervisor.Age}");
//Console.WriteLine($"Averange Letter: {statisticsSupervisor.AverageLetter}");
//Console.WriteLine($"Averange: {statisticsSupervisor.Average}");
//Console.WriteLine($"Min: {statisticsSupervisor.Min}");
//Console.WriteLine($"Max: {statisticsSupervisor.Max}");


Console.WriteLine($"PRACOWNIK: {employee.Name} {employee.SurName} {employee.Age}");
Console.WriteLine($"Averange Letter: {statistics.AverageLetter}");
Console.WriteLine($"Averange: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
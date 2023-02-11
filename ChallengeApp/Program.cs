// Wykonanie Zadania nr 6
//
// Stwórz class Emoloye, w której przechowasz "imię" "nazwisko" "wiek"
// oraz punkty praciwnika w postaci liczb całkowitych.
//
//Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu 1-10.
//
//Napisz program, który wyszuka pracownika z najwyższą liczbą ocen, a następnie wyświetli jego dane i wynik.


using ChallengeApp;

Employee user1 = new Employee("Adam", "Wilczewski", 30);
Employee user2 = new Employee("Kasia", "Lisewska", 25);
Employee user3 = new Employee("Zuzia", "Olesińska", 50);
Employee user4 = new Employee("Zosia", "Rutkowska", 60);

user1.AddScore(5);
user1.AddScore(3);
user1.AddScore(1);
user1.AddScore(7);
user1.AddScore(6);

user2.AddScore(4);
user2.AddScore(2);
user2.AddScore(1);
user2.AddScore(5);
user2.AddScore(3);

user3.AddScore(3);
user3.AddScore(2);
user3.AddScore(1);
user3.AddScore(6);
user3.AddScore(9);

user4.AddScore(5);
user4.AddScore(2);
user4.AddScore(8);
user4.AddScore(7);
user4.AddScore(4);



 List<Employee> employees = new List<Employee>()
        {
            user1, user2, user3, user4
        };

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (Employee employee in employees)
{
    if (employee.Result > maxResult) 
    {
        userWithMaxResult = employee;
    }

}
Console.WriteLine("Największa liczba punktów zebranych przez pracownika to - " + userWithMaxResult.Result);
Console.WriteLine("Imię - " + userWithMaxResult.Name);
Console.WriteLine("Nazwisko - " + userWithMaxResult.SurName);
Console.WriteLine("Wiek - " + userWithMaxResult.Age);
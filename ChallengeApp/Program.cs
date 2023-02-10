// Wykonanie Zadania nr 5
// Przygotuj program, który policzy ile jakich cyfr
// występuje w podanej liczbie.
//
// Przyklad
// Wynik dla liczby: 4566
// 0 => 0
// 1 => 0
// 2 => 0
// 3 => 0
// 4 => 1
// 5 => 1
// 6 => 2
// 7 => 0
// 8 => 0
// 9 => 0


//int number = 456677;
Console.WriteLine("Podaj liczbę:");
string number = Console.ReadLine();
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] results = new int[10];

foreach (char letter in letters)
{
    for (int i = 0; i <= results.Length; i++)
    {
        int num = letter - '0';
        if (num == i)
        {
            results[i]++;
        }

    }
}
for (int j = 0; j < results.Length; j++)
{
    Console.WriteLine("Liczba " + j + " występuje " + "=> " + results[j] + " razy");
}
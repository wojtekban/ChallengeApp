// Wykonanie Zadania nr 4
//"Kobieta poniżej 30 lat";
//"Ewa lat 33"
//"Niepełnoletni mężczyzna";
//"Chłopiec"
//"Kobieta w wieku emerytalnym"
//"Mężczyzna w wieku emerytalnym"

string myName = "Kinga";
bool isWomen = true;
int myAge = 28;

if (isWomen == true && myAge < 30)    //kobieta poniżej 30 lat
            {
                Console.WriteLine("Kobieta poniżej 30 lat.");
            }
else if (myName == "Kinga" && myAge == 33)   //"Kinga lat 33"
            {
                Console.WriteLine("Kinga lat 33");
            }
else if (isWomen == false && myAge >=12 && myAge < 18)   //"Niepełnoletni mężczyzna" 
            {
                Console.WriteLine("Niepełnoletni mężczyzna."); 
            }
else if (isWomen == false && myAge < 12)   //"Chłopiec"
            {
                Console.WriteLine("Chlopiec.");
            }
else if (isWomen == true && myAge >= 60)   //"Kobieta w wieku emerytalnym"
            {
                Console.WriteLine("Kobieta w wieku emerytalnym.");
            }
else if (isWomen == false && myAge >= 75)   //"Mężczyzna w wieku emerytalnym"
            {
            Console.WriteLine("Mężczyzna w wieku emerytalnym.");
            }
else
{
    Console.WriteLine("Nieznana osoba"); //myAge = 18 && myAge = 30 spełnia warunek
}
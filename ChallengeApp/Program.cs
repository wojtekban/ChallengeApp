// Wykonanie Zadania nr 4
//"Kobieta poniżej 30 lat";
//"Ewa lat 33"
//"Niepełnoletni mężczyzna";
//"Chłopiec"
//"Kobieta w wieku emerytalnym"
//"Mężczyzna w wieku emerytalnym"

string myName = "Kinga";
bool myWomen = true;
int myAge = 30;

if (myWomen == true && myAge <= 30)    //kobieta poniżej 30 lat
            {
                Console.WriteLine("Kobieta poniżej 30 lat.");
            }
else if (myName == "Kinga" && myAge == 33)   //"Kinga lat 33"
            {
                Console.WriteLine("Kinga lat 33");
            }
else if (myWomen == false && myAge >=12 && myAge < 18)   //"Niepełnoletni mężczyzna" 
            {
                Console.WriteLine("Niepełnoletni mężczyzna."); 
            }
else if (myWomen == false && myAge < 12)   //"Chłopiec"
            {
                Console.WriteLine("Chlopiec.");
            }
else if (myWomen == true && myAge >= 60)   //"Kobieta w wieku emerytalnym"
            {
                Console.WriteLine("Kobieta w wieku emerytalnym.");
            }
else if (myWomen == false && myAge >= 75)   //"Mężczyzna w wieku emerytalnym"
            {
            Console.WriteLine("Mężczyzna w wieku emerytalnym.");
            }
else
{
    Console.WriteLine("Nieznana osoba"); //myAge = 18 spełnia warunek
}
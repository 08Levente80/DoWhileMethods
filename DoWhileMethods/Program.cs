using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileMethods //Mindig egyezen meg a kódban lévő namespace név a projekt nevével, különben hibát fog jelezni a program.
{
    internal class Program //internal - A Program osztály csak a DoWhileMethods namespace-en belül érhető el.
                           //Több fajtája lehet az elérhetőségi szintnek, pl.: public, private, protected, internal. //class - Osztályt hoz létre.
    {

        static void Koszon() //Void - Nem kell visszatérési érték, nem ad vissza semmit.
        {
            Console.WriteLine("Szia!");
        }

        static void Koszon(string nev) 
        {
            //nev = "Sára";
            Console.WriteLine($"Szia {nev}!");
        }

        static void Bemutatkozas(string nev, int eletkor)
        {
            Console.WriteLine($"Szia {nev}!");
            Console.WriteLine($"A te életkorod: {eletkor}.");
        }

        static int Osszeg(int szam1, int szam2) //int - Van visszatérési érték, visszaad egy egész számot.
        {
            int ossezg = szam1 + szam2;
            return szam1 + szam2;
        }

        static int Osszeadas(int szam1, int szam2)
        {
            return szam1 + szam2;
        }

        static int Kivonas(int szam1, int szam2)
        {
            return szam1 - szam2;
        }

        static int Szorzas(int szam1, int szam2)
        {
            return szam1 * szam2;
        }

        static double Osztas(float szam1, int szam2) //float - Van visszatérési érték, visszaad egy tört számot. //double - Van visszatérési érték, visszaad egy tört számot.
        {
            return szam1 % szam2; // / - osztás, % - maradékos osztás
        }

        static void Koszones(string nev = "Vendég") //"Vendég" - Alapértelmezett érték, ha a felhasználó nem ad meg nevet, akkor a "Vendég" szöveget fogja kiírni.
        {
            Console.WriteLine($"Szia {nev}!");
        }

        static bool NagykoruE(int kor) //bool - Van visszatérési érték, visszaad egy logikai értéket (true/false).
        {
            /*if (kor > 18)
                return true;

            else
                return false;*/

            return kor > 18;
        }

        static void Main(string[] args)
        {
            Koszones();
            /*Koszon();
            //Koszon("István");

            Console.WriteLine("Add meg a neved: ");
            string nev = Console.ReadLine(); //A felhasználó által beírt szöveget a nev változóban tároljuk el.
            //Koszon(nev);

            Console.Write("Add meg az életkorod: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            Bemutatkozas(nev, kor);

            int osszeg = Osszeg(2, 5);
            Console.WriteLine(osszeg);
            Console.WriteLine(Osszeg(2, 5));

            Console.ReadLine(); //A program futásának leállítása, amíg a felhasználó nem nyom meg egy gombot.

            Console.Write("Első szám: "); //Write - Kiírja a szöveget a konzolra, de nem ugrik új sorba.
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Összeadás: {Osszeadas(szam1, szam2)}"); //WriteLine - Kiírja a szöveget a konzolra, és ugrik új sorba.
            Console.WriteLine($"Kivonás: {Kivonas(szam1, szam2)}");
            Console.WriteLine($"Szorzás: {Szorzas(szam1, szam2)}");
            Console.WriteLine($"Osztás: {Osztas(szam1, szam2)}");*/

            string nagykoruE = "";
            if (NagykoruE(16))  //A metódus meghívása, a visszatérési értékét vizsgáljuk. Ha igaz, akkor a true ág fut le, ha hamis, akkor az else ág.
                nagykoruE = "Nagy korú";
            else
                nagykoruE = "Kis korú";

            // ? true ág : else ág
            nagykoruE = NagykoruE(19) ? "Nagy korú" : "Kis korú";

            Console.WriteLine($"A te életszakaszod: {nagykoruE}");


            int szam = 1;
            do //do - A do-while ciklus legalább egyszer lefut, majd a while feltételét vizsgálja. Ha a feltétel igaz, akkor újra lefut, ha hamis, akkor kilép a ciklusból.
            {
                Console.WriteLine(szam);
                szam++; // ++ - Növeli a változó értékét 1-gyel. -- - Csökkenti a változó értékét 1-gyel.
            } while (szam <= 5);



            int valasztas; //deklarálás - A változó létrehozása, de még nincs értéke. //inicializálás - A változó létrehozása és értékadás egyszerre.
            do
            {
                Console.Clear();
                Console.WriteLine("===MENÜ===");
                Console.WriteLine("1.) Köszönés");
                Console.WriteLine("2.) Név bekérés");
                Console.WriteLine("3.) Kilpés");
                Console.Write("Választás: ");
                valasztas = Convert.ToInt32(Console.ReadLine()); //try/catch - A try blokkban lévő kódot próbálja végrehajtani, ha hiba történik, akkor a catch blokkban lévő kódot hajtja végre. //Convert.ToInt32 - A szöveget egész számmá alakítja át. Ha a szöveg nem alakítható át egész számmá, akkor hibát dob.

                switch (valasztas) //witch - A switch utasítás a változó értékét vizsgálja, és a case ágak közül a megfelelő ágat hajtja végre. Ha nincs megfelelő ág, akkor a default ág fut le.
                {
                    case 1: // case "1" - A case ágban lévő kódot hajtja végre, ha a változó értéke megegyezik a case ág értékével. //break - A switch utasításból való kilépés. Ha nincs break, akkor a következő case ág is lefut.
                        Koszones();
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Mi a neved?: ");
                        string nev = Console.ReadLine();
                        Console.WriteLine($"Szia {nev}!");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Kilépés....");
                        Console.ReadLine();
                        break;

                    default: //default - Ha nincs megfelelő case ág, akkor a default ág fut le.
                        Console.WriteLine("Nincs ilyen menüpont");
                        Console.ReadLine();
                        break;
                }
            } while (valasztas != 3);

            Console.ReadLine();
        }
    }
}

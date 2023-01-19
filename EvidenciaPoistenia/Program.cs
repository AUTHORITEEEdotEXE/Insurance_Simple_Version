using EvidenciaPoistenia;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Collections;

Zoznam zoznam = new Zoznam();
bool konec = false;
List<Poistenec> poistenci = new List<Poistenec>();



while(!konec)
{
    ZobrazMenu();
    
    string volba = Console.ReadLine(); 
    // moznosti z menu 
    switch (volba)
    {
        case "1":
            Poistenec poistenec = zoznam.VytvorPoistenca();
            poistenci.Add(poistenec);
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();

            break;
        case "2":
            zoznam.VypisPoistencov(poistenci);
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();

            break;

        case "3":
            zoznam.NajdiPoistenca(poistenci);

            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();

            break;

        case "4":
            konec = true;
            
            break;

        default:
            Console.WriteLine("Nesprávna volba. Prosím zadejte znovu.");
            Console.ReadKey();


            break;
    }

    
}

// zobrazenie moznosti v menu
static void ZobrazMenu()
{
    
    Console.Clear();    
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Evidence pojištených");
    Console.WriteLine("----------------------------------");
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojišteného");
    Console.WriteLine("2 - Vypsat všechny pojištené");
    Console.WriteLine("3 - Vyhledat pojišteného");
    Console.WriteLine("4 - Konec");
    Console.WriteLine("----------------------------------");
    Console.WriteLine();
}


/////////////////////// Vo statickych funkciach(bez objektu Zoznam) ////////////////////////////

//static Poistenec VytvorPoistenca()
//{
//    Console.WriteLine("Zadajte meno:");
//    string meno = Console.ReadLine();
//    Console.WriteLine("Zadejte prijmeni:");
//    string priezvisko = Console.ReadLine();
//    Console.WriteLine("Zadejte telefonni cislo:");
//    string telCislo = Console.ReadLine();
//    Console.WriteLine("Zadejte vek:");
//    int vek = int.Parse(Console.ReadLine());    
//    Poistenec poistenec = new Poistenec(meno, priezvisko, telCislo, vek);
       
//    return poistenec;
//}

//static void NajdiPoistenca(List<Poistenec> poistenci)
//{
//    Console.WriteLine("Zadajte meno hladaneho poistenca:");
//    string hladaneMeno = Console.ReadLine();
//    Console.WriteLine("Zadajte prijmeni hladaneho poistenca:");
//    string hladanePriezvisko = Console.ReadLine();
//    Console.WriteLine();
    
    
    
//    var vyhladanie = from p in poistenci
//                    where hladaneMeno == p.Meno && hladanePriezvisko == p.Priezvisko
//                    select p;
//    Console.WriteLine("Vyhladavani poistenci:");
//    foreach (Poistenec poistenec in vyhladanie)
//    {
//        Console.WriteLine(poistenec);
//    }
//}

//static void VypisPoistencov(List<Poistenec> poistenci
//    )
//{
//    Console.WriteLine("Zoznam poistencov");
//    for (int i = 0; i < poistenci.Count(); i++)
//    {
//        Console.WriteLine(poistenci[i]);
//    }
//}

Console.ReadKey();
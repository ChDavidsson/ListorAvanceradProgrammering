using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace ListorAvanceradProgrammering;

class Program
{
    static void Main(string[] args)
    {
        // List<int> reverse = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // public static List<int> omvänd = ReverseList();
        // {
            
        // }

        // List<int> dubletter = new List<int> {1, 2, 2, 3, 3, 4, 4, 5};

        // List<int> listaUtanDubletter = TaBortDubletter(dubletter);

        // Console.WriteLine(string.Join(", ", listaUtanDubletter));

        // static List<int> TaBortDubletter(List<int> listaMedDubletter)
        // {
        //     return listaMedDubletter.Distinct().ToList();
        // }


        // List<string> sortera = new List<string> {"mat", "äpplen", "gurka", "apelsin", "korv"};
        
        // List<string> färdigsorteradList = SorteraLista(sortera);

        // Console.WriteLine(string.Join(", ", färdigsorteradList));
        
        // // Uppgift: Skriv en metod som sorterar en lista med strängar 
        // // baserat på deras längd (kortast till längst). 
        // // Använd metoden Sort med en anpassad jämförelse.
        // static List<string> SorteraLista(List<string> listaSomÄrSorterad)
        // {
        //     listaSomÄrSorterad.Sort((a,b) => a.Length - b.Length);
        //     return listaSomÄrSorterad;
        // }

        
        
        
        
        // Övning 1: LINQ Where och OrderBy
        // Uppgift: Givet en lista med produkter (med egenskaperna Namn och Pris), skriv en LINQ-fråga
        // som filtrerar produkter med ett pris över 50 och sorterar dem i fallande ordning efter pris.
        List<Produkt> produktLista = new List<Produkt>
        {
            new Produkt { Namn = "Tavla", Pris = 120 },
            new Produkt { Namn = "Penna", Pris = 30 },
            new Produkt { Namn = "Bok", Pris = 50 },
            new Produkt { Namn = "Lampa", Pris = 160 },
            new Produkt { Namn = "Bord", Pris = 200 },
        };

        

    }
}

// Inmätning
using Lager;

static void Inmätning(Artikel a)
{
    Console.WriteLine("Inköpspris: ");
    a.GetSetPris = double.Parse(Console.ReadLine());
    Console.WriteLine("Kvantitet: ");
    a.GetSetKvantitet = int.Parse(Console.ReadLine());
    Console.WriteLine("Tilvärkaren: ");
    a.GetSetTillverkaren = Console.ReadLine();
    Console.WriteLine("Sålda kvantitetet: ");
    a.GetSetSåldKvantitet = int.Parse(Console.ReadLine());
    Console.WriteLine("*************************************************");
}

// Utskrift
static void Utskrift(Artikel a)
{
    Console.WriteLine("Inköpspris {0:F2}", a.GetSetPris);
    Console.WriteLine("Försäljningspriset {0:F2}", a.BeräknaPriset(a.GetSetSåldKvantitet));
    Console.WriteLine("Inköpt kvantitet: {0}", a.GetSetKvantitet);
    Console.WriteLine("Tillvärkaren: {0}", a.GetSetTillverkaren);
    Console.WriteLine("Mängd sålda varor: {0}", a.GetSetSåldKvantitet);
    Console.WriteLine("Aktuell mängd varor: {0}", a.GetSetKvantitet - a.GetSetSåldKvantitet);

}

int i = 0;
double totalVärde, vinsten;
totalVärde = 0.0;
vinsten = 0.0;
string[] s = { "Socker", "Choklad", "Kaffe" };

Artikel[] a = new Artikel[3]; // en array med n pekare till data av typen Artikel

a[0] = new Socker();
a[1] = new Choklad();
a[2] = new Kaffe();

foreach (Artikel t in a)
{
    Console.WriteLine(s[i++]);
    // t = new Artikal(); // standard konstruktoranrop
    Inmätning(t);
    //beräkning av det totala försäljningspriset för alla
    vinsten += (t.BeräknaPriset(t.GetSetSåldKvantitet) - t.GetSetPris) * t.GetSetSåldKvantitet;
    //beräkning av den totala inköpspriset för alla varor
    totalVärde += t.GetSetPris * t.GetSetKvantitet;
}

Console.WriteLine();
Console.WriteLine("Totalt värde på varor i lagret: {0:F2}", totalVärde);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Information om aktuella status Artiklar: ");
i = 0;
foreach (Artikel t in a)
{
    Console.WriteLine(s[i++]);
    Utskrift(t);
    Console.WriteLine();
}
Console.WriteLine("------------------------------------------------");
Console.WriteLine();
Console.WriteLine();

// Utskrift av realiserad vinst

Console.WriteLine("Vinst: {0:F2}", vinsten);
Console.ReadLine();



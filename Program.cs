// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using PP_uke_4;

List<Bil> biler = new List<Bil>(4)
{
    new Bil("Jaguar",1999,"KH37069",145900),
    new Bil("Mercedes-Benz",2013,"LJ51348",145000),
    new Bil("Toyota",2019,"PR54759",73300),
    new Bil("Volvo",2019,"AJ89795",52500)
};

List<Kunde> kunder = new List<Kunde>();

 void KjøpeBil(Bil bil, List<Bil> MineBiler)
{
    MineBiler.Add(bil);
    biler.Remove(bil);
}

void printAllList()
{   
    Console.WriteLine("Her er biler vi har nå");
    foreach (var bil in biler)
    {
        bil.PrintListe();
    }
}

void printMyList(Kunde kunde)
{   
    Console.WriteLine("Her er biler du eier");
    foreach (var bil in kunde.MineBiler)
    {
            Console.WriteLine(string.Empty.PadLeft(30,'*'));
            Console.WriteLine($"Merke: {bil.Merke}\n" +
                              $"Årsmodell: {bil.Årsmodell}\n" +
                              $"Registreringsnummer: {bil.Registreringsnummer}\n" +
                              $"Kilometerstand: {bil.Kilometerstand}");
    }
}

Kunde kunden;
Console.WriteLine("Hvem er du?\n" +
                  "1. Alex\n" +
                  "2. Benz");
while (true)
{
    string answer = Console.ReadLine();
if ( answer == "1")
{
    Kunde kunde1 = new Kunde("Alex");
    kunder.Add(kunde1);
    kunden = kunder[0];
    break;
}

else if (answer  == "2")
{
    Kunde kunde2 = new Kunde("Benz");
    kunder.Add(kunde2);
    kunden = kunder[0];
    break;

}
else{Console.WriteLine("invalid answer");}
}
Console.Clear();
Console.WriteLine("Velkommen");



    printAllList();
    Console.WriteLine("Hvilken bil ønsker du å kjøpe?");
    switch (Console.ReadLine())
    {
        case "1":
            KjøpeBil(biler[0], kunden.MineBiler);
            printMyList(kunden);
            break;
        case "2":
            KjøpeBil(biler[1], kunden.MineBiler);
            printMyList(kunden);
            break;
        case "3":
            KjøpeBil(biler[2], kunden.MineBiler);
            printMyList(kunden);
            break;
        case "4":
            KjøpeBil(biler[3], kunden.MineBiler);
            printMyList(kunden);
            break;
        default:
            Console.WriteLine("invalid answer");
            break;

    }
    

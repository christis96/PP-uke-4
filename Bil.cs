namespace PP_uke_4;

public class Bil
{
    public string Merke { get; private set; }
    public int Årsmodell { get; private set; }
    public string Registreringsnummer { get; private set; }
    public int Kilometerstand { get; private set; }
    
    public Bil(string merke, int årsmodell, string registreringsnummer, int kilometerstand)
    {
     Merke = merke;
     Årsmodell = årsmodell;
     Registreringsnummer = registreringsnummer;
     Kilometerstand = kilometerstand;
    }
    
    public void PrintListe()
    {
            Console.WriteLine(string.Empty.PadLeft(30,'*'));
            Console.WriteLine($"Merke: {Merke}\n" +
                              $"Årsmodell: {Årsmodell}\n" +
                              $"Registreringsnummer: {Registreringsnummer}\n" +
                              $"Kilometerstand: {Kilometerstand}");

    }



}
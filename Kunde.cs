namespace PP_uke_4;

public class Kunde
{
    public string Navn;
    public List<Bil> MineBiler = new List<Bil>();

    public Kunde(string navn)
    {
        Navn = navn;
        List<Bil> MineBiler = new List<Bil>();
    }


    
}
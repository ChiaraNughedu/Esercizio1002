using Esercizio1002;

class Program
{
    static void Main()
    {
        
        Atleta atleta = new Atleta { _firstName = "Filippo Tortu", _sport = "Atletica", _age = 26 };
        Dipendente dipendente = new Dipendente { _name = "Chiara", _role = "Front-End Developer", _salary = 3500 };
        Animale animale = new Animale { _name = "Pirlo", _species = "Gatto", _age = 2 };
        Veicolo veicolo = new Veicolo { _brand = "Fiat", _name = "Panda", _year = 2003 };

      
        atleta.Print();
        dipendente.Print();
        animale.Print();
        veicolo.Print();
    }
}
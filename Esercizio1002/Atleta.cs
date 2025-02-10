namespace Esercizio1002
{
    public class Atleta
    {
        public string _firstName { get; set; }
        public string _sport { get; set; }
        public int _age { get; set; }

        public void Print()
        { 
            Console.WriteLine($"Atleta: {_firstName}, Sport: {_sport}, Età: {_age}");
        }
}
    }

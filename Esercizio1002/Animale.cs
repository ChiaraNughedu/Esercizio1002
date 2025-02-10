

using System.Data;

namespace Esercizio1002
{
    public class Animale
    {
        public string _name { get; set; }
        public string _species { get; set; }
        public int _age { get; set; }

        public void Print()
        {
            Console.WriteLine($"Nome: {_name}, Specie: {_species}, Età: {_age}");
        }
    }
}

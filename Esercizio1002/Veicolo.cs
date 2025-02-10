
using System.Data;

namespace Esercizio1002
{
    public class Veicolo
    {
        public string _brand { get; set; }
        public string _name { get; set; }
        public int _year { get; set; }

        public void Print()
        {
            Console.WriteLine($"Produttore: {_brand}, Veicolo: {_name}, Anno: {_year}");
        }
    }
}

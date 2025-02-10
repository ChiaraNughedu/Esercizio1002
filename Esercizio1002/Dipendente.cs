
namespace Esercizio1002
{
    public class Dipendente
    {
        public string _name { get; set; }
        public string _role { get; set; }
        public int _salary { get; set; }

        public void Print()
        {
            Console.WriteLine($"Dipendente: {_name}, Ruolo: {_role}, Stipendio: {_salary}");
        }

    }
}

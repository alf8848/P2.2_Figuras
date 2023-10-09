using System; // Agrega esta línea para poder usar Console y DateTime

namespace _08_list
{
    public class ListaObjetos
    {
        public static void Main(string[] args)
        {
            Evento ev1 = new Evento(new DateTime(2008, 3, 4, 0, 0), new TimeSpan(1, 0, 0), "Cumpleaños de cuchi", "Es el cumpleaños de tu perro");
            Console.WriteLine(ev1);

            List<Evento> lista_eventos = new List<Evento>(); // Declarar e inicializar la lista

            lista_eventos.Add(new Evento(new DateTime(2018, 2, 6, 2, 2), new TimeSpan(1, 0, 0), "Cumpleaños de paco", "Es el cumpleaños de tu paco"));
            lista_eventos.Add(new Evento(new DateTime(2004, 4, 1, 3, 0), new TimeSpan(4, 0, 0), "Cumpleaños de felipe", "Es el cumpleaños de tu felipe"));
            lista_eventos.Add(new Evento(new DateTime(2020, 1, 1, 0, 0), new TimeSpan(2, 0, 0), "Cumpleaños de ferran", "Es el cumpleaños de tu ferran"));

            foreach (Evento ev in lista_eventos)
            {
                Console.WriteLine(ev);
            }
        }
    }
}

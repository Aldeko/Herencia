using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolistas f1 = new Futbolistas(123, "Abelardo", "Garcia", 23, 9, "delantero");
            Entrenador e1 = new Entrenador(88, "Berizzo", "aldekotarola", 45, "675");
            Masajistas m1 = new Masajistas(11, "Luis", "Baquero", 99, 70, "fisioterapeuta");
            SeleccionFutbol s1 = new SeleccionFutbol();

            Console.WriteLine(f1.ToStringFutbolistas());
            Console.WriteLine(e1.ToStringEntrenador());
            Console.WriteLine(m1.ToStringMasajistas());
            

            Console.ReadLine();
        }
    }
}

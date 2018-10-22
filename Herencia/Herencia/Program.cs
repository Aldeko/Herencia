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


            List<SeleccionFutbol> listaMasajistas = new List<SeleccionFutbol>()
            {
              m1
            };

            foreach (SeleccionFutbol masajista in listaMasajistas)
            {
                if (masajista.GetType().ToString() == "Masajista")
                {
                    Console.WriteLine(masajista);
                }
            }

            List<SeleccionFutbol> listaEntrenador = new List<SeleccionFutbol>()
            {
              e1
            };
            foreach (SeleccionFutbol entrenador in listaEntrenador)
            {
                if (entrenador.GetType().ToString() == "Entrenador")
                {
                    Console.WriteLine(entrenador);

                }
            }
            List<Futbolistas> listaFutbolistas = new List<Futbolistas>()
            {
              f1
            };
            foreach (SeleccionFutbol futbolista in listaFutbolistas)
            {
                if (futbolista.GetType().ToString() == "Futbolista")
                {
                    Console.WriteLine(futbolista);
                }
            }

            List<SeleccionFutbol> listaSeleccion = new List<SeleccionFutbol>()
            {
                f1, m1, e1
            };
            foreach(SeleccionFutbol trabajo in listaSeleccion)
            {
                Console.WriteLine(trabajo.GetType().Name.ToUpper());
                Console.WriteLine(trabajo.MostrarDatos());
                Console.WriteLine("***************************");
            }
            Console.ReadLine();




        }

    }
}



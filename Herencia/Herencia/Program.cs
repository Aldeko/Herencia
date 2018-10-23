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
            Futbolistas f1 = new Futbolistas(23, "Abelardo", "asa", 23, 9, "delantero");
            Futbolistas f2 = new Futbolistas(45, "miguel", "er", 22, 4, "portero");
            Futbolistas f3 = new Futbolistas(56, "German", "gggg", 43, 6, "defensa");
            Futbolistas f4 = new Futbolistas(67, "Peio", "hlkj", 34, 2, "medio");

            Entrenador e1 = new Entrenador(88, "Berizzo", "aldekotarola", 45, "675");
            Entrenador e2 = new Entrenador(44, "Nico", "daf", 12, "675");
            Entrenador e3 = new Entrenador(22, "Bert", "adffg", 44, "675");
            Entrenador e4 = new Entrenador(11, "Hecto", "yyj", 55, "675");

            Masajistas m1 = new Masajistas(11, "carla", "Jefa", 99, 70, "fisioterapeuta");
            Masajistas m2 = new Masajistas(15, "arrate", "Becaria", 99, 70, "masajista de pies");
            Masajistas m3 = new Masajistas(17, "iker", "simpson", 99, 70, "botillero");
            Masajistas m4 = new Masajistas(19, "elene", "La que manda", 99, 70, "medico");

            SeleccionPais p1 = new SeleccionPais("ARGENTINA");
            SeleccionFutbol s1 = new SeleccionFutbol();
            p1.participante.AltaSeleccion.Add(m1);
           


            //Console.WriteLine(f1.ToStringFutbolistas());
            //Console.WriteLine(e1.ToStringEntrenador());
            //Console.WriteLine(m1.ToStringMasajistas());
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

            

            Console.ReadLine();

        }

    }
}



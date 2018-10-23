using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class SeleccionPais
    {
        private string pais;
        private int numPais;
        public List<SeleccionFutbol> participante;
        private static int numeroEntrenadores, numeroMasajistas;

        public SeleccionPais ()
        {
            
        }
        public SeleccionPais(string pais)
        {
            this.pais = pais;
            participante = new List<SeleccionFutbol>();
            
        }
       
        public void MostrarDatosSeleccion()
        {
            Console.WriteLine("PAIS" + pais + "Numero de integrantes" + participante.Count);

            foreach (SeleccionFutbol item in participante)
            {
                Console.WriteLine(item.MostrarDatos());
            }
        }

        public void AñadirParticipante(SeleccionFutbol f)
        {
            if (AltaSeleccion(f))
            {
                if (f.GetType().Name=="Entrenador")
                {
                    numeroEntrenadores++;
                }
                else if (f.GetType().Name=="Masajista")
                {
                    numeroMasajistas++;
                }
                Console.WriteLine("Participante tipo " + f.GetType().Name + " añadido.");
                participante.Add(f);
            }
        }
        public bool AltaSeleccion(SeleccionFutbol f)
        {
            if (participante.Count<31)
            {
                if (f.GetType().Name == "Masajista" && numeroMasajistas < 5)
                {
                    return true;
                }
                else if (f.GetType().Name == "Entrenador" && numeroEntrenadores < 3)
                {
                    return true;
                }
                else if (f.GetType().Name == "Futbolista")
                {
                    return true;
                }
                Console.WriteLine("No caben más " + f.GetType().Name + "En la lista");
                Console.ReadLine();
                return false;
            }
            Console.WriteLine("No caben más " + f.GetType().Name + "en la lista");
            Console.ReadLine();
            return false;
        }
        public void QuitarParticipante(SeleccionFutbol f)// "f"===>HIJAS
        {
            if (BajaSeleccion(f, f.GetId()))
            {
                if (f.GetType().Name == "Entrenador")
                {
                    numeroEntrenadores--;
                }
                else if (f.GetType().Name == "Masajista")
                {
                    numeroMasajistas--;
                }
                Console.WriteLine("Participante tipo " + f.GetType().Name + " suprimido.");
                participante.Remove(f);
            }
        }

        public bool BajaSeleccion(SeleccionFutbol f, int id)
        {
            if (f.GetId() == id)
            {

                return true;
            }
            else
                return false;          
        }

        public void PrepararPartido()
        {
            foreach (SeleccionFutbol item in participante)
            {
                Console.WriteLine("El" + item.GetType().Name + " " + item.GetNombre());
                item.Viajar();
                item.Concertrarse();
                if (item.GetType().Name == "Masajista")
                {
                    Console.WriteLine("Esta dando masajes");
                }
                else if (item.GetType().Name=="Entrenador")
                {
                    Console.WriteLine("Esta dirigiendo entrenamiento");

                }
                else if (item.GetType().Name=="Futbolista")
                {
                    Console.WriteLine("Esta entrenando");
                }

            }
        }

        public void JugarPartido()
        {
            foreach (SeleccionFutbol item in participante)
            {
                Console.WriteLine("El" + item.GetType().Name + " " + item.GetNombre());
                item.Viajar();
                item.Concertrarse();
                if (item.GetType().Name == "Masajista")
                {
                    Console.WriteLine("Esta dando masajes");
                }
                else if (item.GetType().Name == "Entrenador")
                {
                    Console.WriteLine("Esta dirigiendo Partido");

                }
                else if (item.GetType().Name == "Futbolista")
                {
                    Console.WriteLine("Esta jugando partido");
                }

            }
        }

        
    }
}

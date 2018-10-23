using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Futbolistas:SeleccionFutbol
    {
        private int dorsal;
        private string demarcacion;



        public Futbolistas()
        {
        }

        public Futbolistas(int id, string nombre, string apellidos, int edad, int dorsal, string demarcacion):base(id,nombre,apellidos, edad)
        {
            this.dorsal = dorsal;
            this.demarcacion = demarcacion;
            
        }
        public int GetDorsal()
        {
            return dorsal;
        }
        public string GetDemarcacion()
        {
            return demarcacion;
        }
        public void SetDorsal(int dorsal)
        {
            this.dorsal = dorsal;
        }
        public void SetDemarcacion(string demarcacion)
        {
            this.demarcacion = demarcacion;
        }
        
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + " Dorsal: " + dorsal + " Demarcacion: " + demarcacion;
        }
        public void JugarPartido()
        {
            Console.WriteLine("Jugando Partido");
        }
        public void Entrenar()
        {
            Console.WriteLine("Entrenando");

        }
    }
}

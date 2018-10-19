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
        public string ToStringFutbolistas()
        {
            return base.ToString() + " Dorsal: " + dorsal + " Demarcacion: " + demarcacion;
        }
    }
}

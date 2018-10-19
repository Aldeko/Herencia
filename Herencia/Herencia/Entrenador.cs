using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Entrenador:SeleccionFutbol
    {
        private string idFederacion;
        
        public Entrenador ()
        {

        }
        public Entrenador(int id, string nombre, string apellidos, int edad, string idFederacion) : base(id, nombre, apellidos, edad)
        {

        }

        public string GetIdFederacion()
        {
            return idFederacion;
        }
        public void SetIdFederacion(string idFederacion)
        {
            this.idFederacion = idFederacion;
        }
        public string ToStringEntrenador()
        {
            return base.ToString() + " Dorsal: " + idFederacion;
        }

    }
}

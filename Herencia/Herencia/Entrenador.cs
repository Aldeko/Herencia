using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Entrenador : SeleccionFutbol
    {
        private string idFederacion;



        public Entrenador()
        {

        }
        public Entrenador(int id, string nombre, string apellidos, int edad, string idFederacion) : base(id, nombre, apellidos, edad)
        {
            this.idFederacion = idFederacion;

        }

        public string GetIdFederacion()
        {
            return idFederacion;
        }
        public void SetIdFederacion(string idFederacion)
        {
            this.idFederacion = idFederacion;
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + " Dorsal: " + idFederacion;
        }

        public void DirigirPartido ()
        {
            Console.WriteLine("Dirigiendo Partido");
        }

        public void DirigirEntrenamiento()
        {
            Console.WriteLine("Dirigir entrenamiento");
        }
            
       
    }
        
     
    
}

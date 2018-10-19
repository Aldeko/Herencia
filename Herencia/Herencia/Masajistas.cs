using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Masajistas:SeleccionFutbol
    {
        private string titulacion;
        private int aniosExperiencia;



        public Masajistas()
        {

        }
        public Masajistas(int id, string nombre, string apellidos, int edad, int aniosExperiencia, string titulacion) : base(id, nombre, apellidos, edad)
        {
            this.aniosExperiencia = aniosExperiencia;
            this.titulacion = titulacion;
            
        }
        public string GetTitulacion()
        {
            return titulacion;
        }
        public void SetTitulacion(string titulacion)
        {
            this.titulacion = titulacion;
        }
        public int GetAniosExperiencia()
        {
            return aniosExperiencia;
        }
        public void SetAniosExperiencia(int aniosExperiencia)
        {
            this.aniosExperiencia = aniosExperiencia;
        }

        public string ToStringMasajistas()
        {
            return base.ToString() + " Titulacion: " + titulacion + " Años de Experiencia: " + aniosExperiencia;
        }

    }
}

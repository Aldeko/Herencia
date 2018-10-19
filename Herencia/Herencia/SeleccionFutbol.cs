using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class SeleccionFutbol
    {
        private int id, edad;
        private string nombre, apellidos;
        private static int cont = 0;
        
        public SeleccionFutbol()
        {

        }
        public SeleccionFutbol (int id, string nombre, string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            cont++;
        }

        public int GetId()
        {
            return id;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellidos()
        {
            return apellidos;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetId(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public string ToString()
        {
            return "ID: " + id + " Nombre: " + nombre + " Apellidos: " + apellidos + " Edad: " + edad; 
        }
       
    }
}

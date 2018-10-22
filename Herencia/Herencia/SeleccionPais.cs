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
        private List<SeleccionPais> participante;

        public SeleccionPais (string pais)
        {
            this.pais = pais;
            participante = new List<SeleccionPais>();
        }
        public SeleccionPais(string pais, List<SeleccionPais> participante)
        {
            this.pais = pais;
            this.participante = participante;
        }

    }
}

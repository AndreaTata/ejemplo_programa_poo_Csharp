using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODEMO.Models
{
    class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nombre = " ";
            Descripcion = " ";
            Nivel = NivelPoder.NivelUno;
        }
    }

}

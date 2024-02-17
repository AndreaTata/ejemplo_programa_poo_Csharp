using POODEMO.Interfaces;
using POODEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODEMO
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            /*Console.WriteLine($"Id {superHeroe.Id}");
            Console.WriteLine($"Nombre {superHeroe.Nombre}");
            Console.WriteLine($"Identidad Secreta {superHeroe.IdentidadSecreta}");*/

            Console.WriteLine(superHeroe.ObtenerInfoSuperHeroe());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODEMO.Interfaces
{
    internal interface ISuperHeroe
    {
        public int Id { get; set; }
        public string Nombre  { get; set; }
        public string IdentidadSecreta { get; set; }

        string ObtenerInfoSuperHeroe()
        {
            return ($"ID : {Id} \nNombre: {Nombre}\nIdentidadSecreta: {IdentidadSecreta}");
        }





    }



}

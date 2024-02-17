using POODEMO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODEMO.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _Nombre;
        public int Id { get; set; }
        public override string Nombre
        { get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }

        }

        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }

        public string IdentidadSecreta {get; set;}  
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            Id = 0;
            _Nombre = " ";
            Nombre = " ";
            IdentidadSecreta = " ";
            Ciudad = " ";
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public void UsarSuperPoderes()
        {
            foreach (var item in SuperPoderes)
            {
                Console.WriteLine($"{NombreEIdentidadSecreta} esta usando el poder {item.Nombre} !!");
            }

        }

        public string UsarSuperPoderes2()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} esta usando el poder {item.Nombre} !!");
            }

            return sb.ToString();

        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha saldavo al mundo ";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }

    }


}

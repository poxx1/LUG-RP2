using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Propiedades
{
    public class Cliente:Persona
    {
        public DateTime FechaNac { get; set; }
        public string Correo { get; set; }
        public Clase Clase { get; set; }

        //public int Clases { get; set; }
        public int Costo { get; set; }

     
    }
}

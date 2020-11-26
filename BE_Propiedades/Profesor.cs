using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Propiedades
{
    public class Profesor:Persona
    {
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}

using BE_Propiedades;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_informes
    {
        public List<Informe1> Listar1()
        {
            var i = new M_informes();
            return i.Listar1();
        }
        public List<Informe2> Listar2()
        {
            var i = new M_informes();
            return i.Listar2();
        }
    }
}

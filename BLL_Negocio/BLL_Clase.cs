using BE_Propiedades;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Clase
    {
        public List<Clase> Listar()
        {
            var m_C = new M_Clase();
            return m_C.Listar();
        }
        public void Insert(Clase c)
        {
            var mClas = new M_Clase();
            mClas.Insert(c, "CsInsert");
        }
        public void Update(Clase c)
        {
            var mClas = new M_Clase();
            mClas.Insert(c, "CsUpdate");
        }
        public void Delete(Clase c)
        {
            var mClas = new M_Clase();
            mClas.Insert(c, "CsDelete");
        }
    }
}

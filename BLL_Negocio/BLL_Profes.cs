using BE_Propiedades;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Profes
    {
        public List<Profesor> Listar()
        {
            var m_C = new M_Profes();
            return m_C.Listar();
        }
        public void Insert(Profesor f)
        {
            var mClient = new M_Profes();
            mClient.Insert(f, "PInsert");
        }
        public void Update(Profesor f)
        {
            var mClient = new M_Profes();
            mClient.Insert(f, "PUpdate");
        }
        public void Delete(Profesor f)
        {
            var mClient = new M_Profes();
            mClient.Insert(f, "PDelete");
        }
    }
}

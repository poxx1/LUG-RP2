using BE_Propiedades;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Clientes
    {
        public List<Cliente> Listar()
        {
            M_Cliente m_C = new M_Cliente();
            return m_C.Listar();
        }
        public void Insert(Cliente cliente)
        {
            M_Cliente mClient = new M_Cliente();
            mClient.Insert(cliente,"Insert");
        }
        public void Update(Cliente cliente)
        {
            M_Cliente mClient = new M_Cliente();
            mClient.Insert(cliente,"Update");
        }
        public void Delete(Cliente cliente)
        {
            M_Cliente mClient = new M_Cliente();
            mClient.Insert(cliente,"Delete");
        }
    }
}

using BE_Propiedades;
using DAL_SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class M_informes
    {
        public List<Informe1> Listar1()
        {
            List<Informe1> lista = new List<Informe1>();
            var con = new Conexion();
            DataTable dt;
            dt = con.Read("Iuno", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow Item in dt.Rows)
                {
                    var i = new Informe1();
                    i.Clase = Item["Clase"].ToString();
                    i.Cantidad = Convert.ToInt32(Item["Cantidad"].ToString());
                    i.Total = Convert.ToInt32(Item["Total"].ToString());
                   
                    lista.Add(i);
                }
                return lista;
            }
            else
            {
                return null;
            }
        }
        public List<Informe2> Listar2()
        {
            List<Informe2> lista = new List<Informe2>();
            var con = new Conexion();
            DataTable dt;
            dt = con.Read("Idos", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow Item in dt.Rows)
                {
                    var i = new Informe2();
                    i.Clase = Item["Clase"].ToString();
                    i.Total = Convert.ToInt32(Item["Total"].ToString());
                    i.Alumnos = Convert.ToInt32(Item["Alumnos"].ToString());

                    lista.Add(i);
                }
                return lista;
            }
            else
            {
                return null;
            }
        }
    }
}

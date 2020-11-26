using BE_Propiedades;
using DAL_SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class M_Clase
    {
        public List<Clase> Listar()
        {
            var lista = new List<Clase>();
            var con = new Conexion();
            DataTable dt;
            dt = con.Read("SClase", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow Item in dt.Rows)
                {
                    Clase c = new Clase();
                    Profesor p = new Profesor();

                    c.Descripcion = Item["Descripcion"].ToString();
                    //c.profe = Int32.Parse(Item["Profesor"].ToString());
                    c.Dia = Item["Dia"].ToString();
                    c.Turno = (Item["Turno"].ToString());
                    c.Cantidad = Convert.ToInt32(Item["Cantidad"]);
                    p.DNI = Int32.Parse(Item["DNI"].ToString());
                    p.Apellido = Item["Apellido"].ToString();
                    p.Nombre = Item["Nombre"].ToString();
                    c.Profesor = p;

                    lista.Add(c);
                }
                return lista;
            }
            else
            {
                return null;
            }
        }
        public void Insert(Clase c, string Store)
        {
            var query = Store;
            ArrayList AL = new ArrayList();

            if (c.Descripcion != "")
            {
                SqlParameter Param1 = new SqlParameter();
                Param1.ParameterName = "@Descripcion";
                Param1.Value = c.Descripcion;
                Param1.SqlDbType = SqlDbType.VarChar;
                AL.Add(Param1);
            }

            SqlParameter Param2 = new SqlParameter();
            Param2.ParameterName = "@Profesor";
            Param2.Value = c.Profesor.DNI;
            Param2.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param2);

            SqlParameter Param3 = new SqlParameter();
            Param3.ParameterName = "@Dia";
            Param3.Value = c.Dia;
            Param3.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param3);

            SqlParameter Param4 = new SqlParameter();
            Param4.ParameterName = "@Turno";
            Param4.Value = c.Turno;
            Param4.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param4);

            SqlParameter Param5 = new SqlParameter();
            Param5.ParameterName = "@Cantidad";
            Param5.Value = c.Cantidad;
            Param5.SqlDbType = SqlDbType.Int;
            AL.Add(Param5);

            var oDatos = new Conexion();
            oDatos.Write(query, AL);
        }
    }
}

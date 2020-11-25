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
    public class M_Profes
    {
        public List<Profesor> Listar()
        {
            List<Profesor> lista = new List<Profesor>();
            var con = new Conexion();
            DataTable dt;
            dt = con.Read("SProfes", null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow Item in dt.Rows)
                {
                    var p = new Profesor();
                    p.DNI = Convert.ToInt32(Item["DNI"]);
                    p.Nombre = Item["Nombre"].ToString();
                    p.Apellido = Item["Apellido"].ToString();

                    lista.Add(p);
                }
                return lista;
            }
            else
            {
                return null;
            }
        }
        public void Insert(Profesor p, string Store)
        {
            var query = Store;
            ArrayList AL = new ArrayList();

            if (p.DNI != 0)
            {
                SqlParameter Param1 = new SqlParameter();
                Param1.ParameterName = "@DNI";
                Param1.Value = p.DNI;
                Param1.SqlDbType = SqlDbType.Int;
                AL.Add(Param1);
            }

            SqlParameter Param2 = new SqlParameter();
            Param2.ParameterName = "@Nombre";
            Param2.Value = p.Nombre;
            Param2.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param2);

            SqlParameter Param3 = new SqlParameter();
            Param3.ParameterName = "@Apellido";
            Param3.Value = p.Apellido;
            Param3.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param3);

            var oDatos = new Conexion();
            oDatos.Write(query, AL);
        }

    }
}

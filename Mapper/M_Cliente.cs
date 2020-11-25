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
    public class M_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var con = new Conexion();
            DataTable dt;
            dt = con.Read("SCliente",null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow Item in dt.Rows)
                {
                    Cliente c = new Cliente();
                    c.DNI = Convert.ToInt32(Item["DNI"]);
                    c.Nombre = Item["Nombre"].ToString();
                    c.Apellido = Item["Apellido"].ToString();
                    c.Costo = Convert.ToInt32(Item["Costo"]);
                    //ClsEELocalidad oLoc = new ClsEELocalidad();
                    c.Clases = Convert.ToInt32(Item["Clase"]);
                    c.Correo = Item["Correo"].ToString();
                    c.FechaNac = Convert.ToDateTime(Item["FechaNac"]);

                    lista.Add(c);
                }
                return lista;
            }
            else
            {
                return null;
            }
        }
        public void Insert(Cliente c,string Store)
        {
            var query = Store;
            ArrayList AL = new ArrayList();

                if (c.DNI != 0)
                {
                    SqlParameter Param1 = new SqlParameter();
                    Param1.ParameterName = "@DNI";
                    Param1.Value = c.DNI;
                    Param1.SqlDbType = SqlDbType.Int;
                    AL.Add(Param1);
                }

                SqlParameter Param2 = new SqlParameter();
                Param2.ParameterName = "@Nombre";
                Param2.Value = c.Nombre;
                Param2.SqlDbType = SqlDbType.VarChar;
                AL.Add(Param2);

                SqlParameter Param3 = new SqlParameter();
                Param3.ParameterName = "@Apellido";
                Param3.Value = c.Apellido;
                Param3.SqlDbType = SqlDbType.VarChar;
                AL.Add(Param3);

                SqlParameter Param4 = new SqlParameter();
                Param4.ParameterName = "@FechaNac";
                Param4.Value = c.FechaNac;
                Param4.SqlDbType = SqlDbType.Int;
                AL.Add(Param4);

            SqlParameter Param5 = new SqlParameter();
            Param5.ParameterName = "@Correo";
            Param5.Value = c.Correo;
            Param5.SqlDbType = SqlDbType.Int;
            AL.Add(Param5);

            SqlParameter Param6 = new SqlParameter();
            Param6.ParameterName = "@Clases";
            Param6.Value = c.Clases;
            Param6.SqlDbType = SqlDbType.Int;
            AL.Add(Param6);

            SqlParameter Param7 = new SqlParameter();
            Param7.ParameterName = "@Costo";
            Param7.Value = c.Costo;
            Param7.SqlDbType = SqlDbType.Int;
            AL.Add(Param7);

            var oDatos = new Conexion();
            oDatos.Write(query, AL);
        }

        public void Update(Cliente c, string Store)
        { 
        
        }

        public void Delete(Cliente c, string Store)
        { 
            
        }
    }
}

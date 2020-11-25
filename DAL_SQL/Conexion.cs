using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SQL
{
    public class Conexion
    {
        //PC laburo: protected SqlConnection cn = new SqlConnection(@"Server=CPX-L7QBTQ41YG6\SQLEXPRESS01;Initial Catalog=Bohemia;Integrated Security=True");
        protected SqlConnection cn = new SqlConnection(@"Server=DESKTOP-H982BU0\SQLEXPRESS; Initial Catalog=LastraJulianRP2;Integrated Security=True");
        protected SqlTransaction st;
        private SqlCommand cmd;
        public DataTable Read(string Consulta, ArrayList Parametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);
            cmd = new SqlCommand();

            try
            {
                da = new SqlDataAdapter(Consulta, cn);

                if ((Parametros != null))
                {
                    //si la el arraylist esta vacia
                    foreach (SqlParameter dato in Parametros)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }
            }

            catch (SqlException ex)
            {
                throw ex; 
            }
            catch (Exception ex)
            { 
                throw ex; 
            }
            
            da.Fill(dt);
            
            return dt;

        }
        public bool Write(string query, ArrayList ar)
        {
            cn.Open();

            var dt = new DataTable();
            SqlDataAdapter da = default(SqlDataAdapter);

            try
            {
                st = cn.BeginTransaction();

                var cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.Transaction = st;

                da = new SqlDataAdapter(query, cn);

                if ((ar != null))
                {
                    //si la el arraylist esta vacia
                    foreach (SqlParameter dato in ar)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int respuesta = cmd.ExecuteNonQuery();
                st.Commit();
                return true;
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                st.Rollback();
                return false;
            }

            finally
            {
                cn.Close();
            }
        }
    }
}

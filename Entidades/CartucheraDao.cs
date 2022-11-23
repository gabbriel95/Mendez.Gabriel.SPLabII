using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class CartucheraDao
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;

        static CartucheraDao()
        {
            conexion = new SqlConnection("Server=.;Database=CARTUCHERA_DB;Trusted_Connection=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Utiles> ObtenerAllUtilesCartuchera(int idCartuchera) 
        {

            List<Utiles> utiles = new List<Utiles>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * UTILESS WHERE id_cartuchera={idCartuchera}";
                reader = comando.ExecuteReader();

                while (reader.Read()) 
                {
                    if (reader["util"].ToString() == "Lapiz") 
                    {
                        utiles.Add(new Lapiz((int)reader["id"],reader["marca"].ToString(), (decimal)reader["precio"], (Lapiz.eColor)reader["color"]));
                    }

                    if (reader["util"].ToString() == "Goma")
                    {
                        utiles.Add(new Goma((int)reader["id"],reader["marca"].ToString(), (decimal)reader["precio"], (Goma.eTamanio)reader["tamanio"]));
                    }

                    if (reader["util"].ToString() == "Sacapunta")
                    {
                        utiles.Add(new Sacapunta((int)reader["id"],reader["marca"].ToString(), (decimal)reader["precio"], (Sacapunta.eTipo)reader["tipo"]));
                    }


                }


                return utiles;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}

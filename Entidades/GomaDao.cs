using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class GomaDao
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;

        static GomaDao()
        {
            conexion = new SqlConnection("Server=.;Database=CARTUCHERA_DB;Trusted_Connection=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Goma> ObtenerAllGomas()
        {

            List<Goma> gomas = new List<Goma>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * UTILESS WHERE util=Goma";
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    gomas.Add(new Goma((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (Goma.eTamanio)reader["tamanio"]));
                }


                return gomas;

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


        public static bool InsertarGoma(Goma goma)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO GOMAS VALUES ({goma.Id},'{goma.GetType()}','{ goma.Marca}', { goma.Precio},NULL, NULL, '{ goma.Tamanio}', 1)";
                comando.ExecuteNonQuery();
                return true;
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

        public static bool ModificarGoma(Goma goma)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"UPDATE GOMAS SET marca=@marca WHERE id=@id";
                comando.Parameters.AddWithValue("@marca", goma.Marca);
                comando.Parameters.AddWithValue("@id", goma.Id);
                comando.ExecuteNonQuery();
                return true;
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

        public static bool EliminarGoma(int id)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM GOMAS WHERE id=@id";

                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
                return true;
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

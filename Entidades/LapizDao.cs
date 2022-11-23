using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class LapizDao
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;

        static LapizDao()
        {
            conexion = new SqlConnection("Server=.;Database=CARTUCHERA_DB;Trusted_Connection=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Lapiz> ObtenerAllLapices()
        {

            List<Lapiz> lapices = new List<Lapiz>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * UTILESS WHERE util=Lapiz";
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lapices.Add(new Lapiz((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (Lapiz.eColor)reader["color"]));
                }


                return lapices;

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

        public static Lapiz ObtenerLapiz(int lapizId)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * UTILESS WHERE id={lapizId}";
                reader = comando.ExecuteReader();

                Lapiz lapiz = new Lapiz((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (Lapiz.eColor)reader["color"]);
                
                return lapiz;

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

        public static bool InsertarLapiz(Lapiz lapiz)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO LAPICES VALUES ({lapiz.Id},'{lapiz.GetType()}','{lapiz.Marca}', {lapiz.Precio}, NULL, '{lapiz.Color}', NULL, 1)";
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

        public static bool ModificarLapiz(Lapiz lapiz)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"UPDATE LAPICES SET marca=@marca WHERE id=@id";
                comando.Parameters.AddWithValue("@marca", lapiz.Marca);
                comando.Parameters.AddWithValue("@id", lapiz.Id);
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

        public static bool EliminarLapiz(int id)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM LAPIZ WHERE id=@id";

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

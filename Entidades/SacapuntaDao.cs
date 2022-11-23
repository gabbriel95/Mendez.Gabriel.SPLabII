using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class SacapuntaDao
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader reader;

        static SacapuntaDao()
        {
            conexion = new SqlConnection("Server=.;Database=CARTUCHERA_DB;Trusted_Connection=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Sacapunta> ObtenerAllSacapuntas()
        {

            List<Sacapunta> sacapuntas = new List<Sacapunta>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * UTILESS WHERE util=Sacapuntas";
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    sacapuntas.Add(new Sacapunta((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (Sacapunta.eTipo)reader["tipo"]));
                }


                return sacapuntas;

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

        public static Sacapunta ObtenerSacapunta(int sacapuntaId)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * UTILESS WHERE id={sacapuntaId}";
                reader = comando.ExecuteReader();

                Sacapunta sacapunta = new Sacapunta((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (Sacapunta.eTipo)reader["tipo"]);

                return sacapunta;

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


        public static bool InsertarSacapuntas(Sacapunta sacapuntas)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO SACAPUNTAS VALUES ({sacapuntas.Id},'{sacapuntas.GetType()}','{ sacapuntas.Marca}', {sacapuntas.Precio}, '{ sacapuntas.Tipo}', NULL, NULL, 1)";
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

        public static bool ModificarSacapuntas(Sacapunta sacapuntas)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"UPDATE SACAPUNTAS SET marca=@marca WHERE id=@id";

                comando.Parameters.AddWithValue("@marca", sacapuntas.Marca);
                comando.Parameters.AddWithValue("@id", sacapuntas.Id);

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

        public static bool EliminarSacapuntas(int id)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM SACAPUNTAS WHERE id=@id";

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

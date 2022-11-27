using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Entidades.Lapiz;
using static Entidades.Goma;
using static Entidades.Sacapunta;

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
        /*public static Lapiz LeerLapiz()
        {
            Lapiz lapiz;
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM UTILESS WHERE id=lapiz.IdUtil}";
                reader = comando.ExecuteReader();


                lapiz = new Lapiz((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (eColor)Enum.Parse(typeof(eColor), (string)reader["color"]), (int)reader["id_cartuchera"]);


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
        }*/

        public static List<Utiles> LeerUtiles()
        {
            List<Utiles> listaUtiles = new List<Utiles>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM UTILESS";
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["util"].ToString() == "Entidades.Lapiz")
                    {
                        listaUtiles.Add(new Lapiz((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (eColor)Enum.Parse(typeof(eColor), (string)reader["color"]), (int)reader["id_cartuchera"]));
                    }
                    else if (reader["util"].ToString() == "Entidades.Goma")
                    {
                        listaUtiles.Add(new Goma((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (eTamanio)Enum.Parse(typeof(eTamanio), (string)reader["tamanio"]), (int)reader["id_cartuchera"]));
                    }
                    else if (reader["util"].ToString() == "Entidades.Sacapunta")
                    {
                        listaUtiles.Add(new Sacapunta((int)reader["id"], reader["marca"].ToString(), (decimal)reader["precio"], (eTipo)Enum.Parse(typeof(eTipo), (string)reader["tipo"]), (int)reader["id_cartuchera"]));
                    }
                }

                return listaUtiles;

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

        public static void InsertarUtil(Lapiz lapiz)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO UTILESS VALUES ('{lapiz.GetType()}', '{lapiz.Marca}', {lapiz.Precio}, NULL, '{lapiz.Color}',NULL, {lapiz.IdCartuchera})";


                comando.ExecuteNonQuery();

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
        public static void InsertarUtil(Goma goma)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO UTILESS VALUES ('{goma.GetType()}', '{goma.Marca}', {goma.Precio}, NULL, NULL,'{goma.Tamanio}', {goma.IdCartuchera})";


                comando.ExecuteNonQuery();

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

        public static void InsertarUtil(Sacapunta sacapunta)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO UTILESS VALUES ('{sacapunta.GetType()}', '{sacapunta.Marca}', {sacapunta.Precio}, '{sacapunta.Tipo}', NULL,NULL, {sacapunta.IdCartuchera})";


                comando.ExecuteNonQuery();

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



        public static void EliminarUtil(int id)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM UTILESS WHERE id = {id}";

                comando.ExecuteNonQuery();

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

        public static void ModificarUtil(Lapiz lapiz, int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE UTILESS SET util='{lapiz.GetType()}', marca = '{lapiz.Marca}', precio = {lapiz.Precio},tipo = null, color = '{lapiz.Color}', tamanio = null, id_cartuchera = {lapiz.IdCartuchera} WHERE id = {id}";

                comando.ExecuteNonQuery();

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

        public static void ModificarUtil(Goma goma, int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE UTILESS SET util='{goma.GetType()}', marca = '{goma.Marca}', precio = {goma.Precio},tipo = null, color = null, tamanio = '{goma.Tamanio}', id_cartuchera = {goma.IdCartuchera} WHERE id = {id}";

                comando.ExecuteNonQuery();

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

        public static void ModificarUtil(Sacapunta sacapunta, int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE UTILESS SET util='{sacapunta.GetType()}', marca = '{sacapunta.Marca}', precio = {sacapunta.Precio},tipo = '{sacapunta.Tipo}', color = null, tamanio = null, id_cartuchera = {sacapunta.IdCartuchera} WHERE id = {id}";

                comando.ExecuteNonQuery();

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

        public static int GetIdMaximo()
        {
            int id = 0;
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM UTILESS";
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    id = (int)reader["id"];
                }

                return id + 1;

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

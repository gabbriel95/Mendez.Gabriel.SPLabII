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
        //private static SqlDataReader reader;

        static CartucheraDao()
        {
            conexion = new SqlConnection("Server=.;Database=CARTUCHERA_DB;Trusted_Connection=True");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

    

    }
}

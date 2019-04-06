using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class HeroeNegocio
    {

        public List<Heroe> listarHeroes()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Heroe> listado = new List<Heroe>();
            Heroe nuevo;
            try
            {
                conexion.ConnectionString = "data source=.; initial catalog=SUPERHEROES_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre, Debilidad From PERSONAJES";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Heroe();
                    nuevo.Nombre = lector.GetString(0);
                    nuevo.Debilidad = lector.GetString(1);
                    listado.Add(nuevo);
                }

                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}

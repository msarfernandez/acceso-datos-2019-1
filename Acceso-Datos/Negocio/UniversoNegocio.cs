using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class UniversoNegocio
    {

        public List<Universo> listarUniversos()
        {
            List<Universo> listado = new List<Universo>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Universo uni;
            try
            {
                accesoDatos.setearConsulta("Select IdUniverso, Descripcion from UNIVERSOS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    uni = new Universo();
                    uni.Id = (int)accesoDatos.Lector["IdUniverso"];
                    uni.Nombre = accesoDatos.Lector["Descripcion"].ToString();
                    listado.Add(uni);
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}

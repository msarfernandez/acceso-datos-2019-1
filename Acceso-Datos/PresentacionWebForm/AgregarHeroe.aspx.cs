using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace PresentacionWebForm
{
    public partial class AgregarHeroe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Heroe heroeNuevo = new Heroe();
            HeroeNegocio heroeNegocio = new HeroeNegocio();

            try
            {
                heroeNuevo.Nombre = txtNombre.Text;
                heroeNuevo.Debilidad = txtDebilidad.Text;

                heroeNegocio.agregarHeroeSP(heroeNuevo);
            }
            catch (Exception ex)
            {
                Session.Add("errorLoco", ex);
                Response.Redirect("PaginaError.aspx");
            }



        }
    }
}
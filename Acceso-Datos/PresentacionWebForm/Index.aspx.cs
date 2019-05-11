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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPresioname_Click(object sender, EventArgs e)
        {
            Heroe heroe = new Heroe();
            HeroeNegocio heroeNegocio = new HeroeNegocio();
            heroe.Nombre = "Ironman";
            //lblSaludo.Text = "hola " + txtNombre.Text + " El heroe es " + heroe.Nombre;
            List<Heroe> lista = heroeNegocio.listarHeroes();
            lblSaludo.Text = lista[0].Nombre + ", " + lista[0].Debilidad;
        }
    }
}
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
            HeroeNegocio heroeNegocio = new HeroeNegocio();
            List<Heroe> lista = heroeNegocio.listarHeroes();
            dgvHeroes.DataSource = lista;
            dgvHeroes.DataBind();

        }

        protected void btnPresioname_Click(object sender, EventArgs e)
        {
            //Heroe heroe = new Heroe();
            //heroe.Nombre = "Ironman";
            //lblSaludo.Text = "hola " + txtNombre.Text + " El heroe es " + heroe.Nombre;
            //lblSaludo.Text = lista[0].Nombre + ", " + lista[0].Debilidad;

            //dgvHeroes.Columns[0].Visible = false;
            //dgvHeroes.Columns["SuperPoder"].Visible = false;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AgregarHeroe.aspx");
        }
    }
}
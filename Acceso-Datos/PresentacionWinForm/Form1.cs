using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace PresentacionWinForm
{
    public partial class Form1 : Form
    {

        private List<Heroe> listaHeroesLocal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaSuperheroe alta = new frmAltaSuperheroe();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //doy de alta el formulario de ALTA pero para modificar, entonces le paso por constructor
                //el heroe seleccionado en la grilla.
                frmAltaSuperheroe modificar = new frmAltaSuperheroe((Heroe)dgvPersonajes.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarGrilla()
        {
            HeroeNegocio negocio = new HeroeNegocio();
            try
            {
                listaHeroesLocal = negocio.listarHeroes();
                dgvPersonajes.DataSource = listaHeroesLocal;
                dgvPersonajes.Columns[0].Visible = false;
                dgvPersonajes.Columns[1].Visible = false;
                //dgvPersonajes.Columns[4].Visible = false;
                //dgvPersonajes.Columns[5].Visible = false;
                //dgvPersonajes.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dgvPersonajes.DataSource = listaHeroesLocal;
            }
            else
            {
                if (txtBusqueda.Text.Length >= 3)
                {
                    List<Heroe> lista;
                    lista = listaHeroesLocal.FindAll(X => X.Nombre.Contains(txtBusqueda.Text) || X.Universo.Nombre.Contains(txtBusqueda.Text));
                    dgvPersonajes.DataSource = lista;
                }
            }
        }
    }
}

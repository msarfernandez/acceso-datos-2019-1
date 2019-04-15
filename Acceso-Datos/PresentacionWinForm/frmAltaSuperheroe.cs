using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWinForm
{
    public partial class frmAltaSuperheroe : Form
    {
        public frmAltaSuperheroe()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Heroe heroe = new Heroe();
            HeroeNegocio negocio = new HeroeNegocio();
            try
            {
                heroe.Nombre = txtNombre.Text;
                heroe.Debilidad = txtDebilidad.Text;
                heroe.UsaCapa = ckbCapa.Checked;
                heroe.Volador = ckbVuela.Checked;
                heroe.Universo = (Universo)cboUniverso.SelectedItem;

                negocio.agregarHeroe(heroe);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaSuperheroe_Load(object sender, EventArgs e)
        {
            Universo uni1 = new Universo();
            Universo uni2 = new Universo();

            uni1.Id = 1;
            uni1.Nombre = "Marvel";
            uni2.Id = 2;
            uni2.Nombre = "DC";
            List<Universo> listaUniversos = new List<Universo>();
            listaUniversos.Add(uni1);
            listaUniversos.Add(uni2);

            cboUniverso.DataSource = listaUniversos;            

        }
    }
}

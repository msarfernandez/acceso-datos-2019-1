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
        //MSF-20190420: variable local tipo Heroe con null, a no ser que venga cargada por constructor.
        private Heroe heroeLocal = null;

        public frmAltaSuperheroe()
        {
            InitializeComponent();
        }

        //MSF-20190420: nuevo constructor para recibir por parametro un heroe a modificar. El mismo será seleccionado desde la ventana de listado de heroes.
        public frmAltaSuperheroe(Heroe heroe)
        {
            InitializeComponent();
            heroeLocal = heroe;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Heroe heroe = new Heroe();
            HeroeNegocio negocio = new HeroeNegocio();
            try
            {
                //MSF-20190420: ahora pasamos a usar siempre la variable heroeLocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (heroeLocal == null)
                    heroeLocal = new Heroe();

                heroeLocal.Nombre = txtNombre.Text;
                heroeLocal.Debilidad = txtDebilidad.Text;
                heroeLocal.UsaCapa = ckbCapa.Checked;
                heroeLocal.Volador = ckbVuela.Checked;
                heroeLocal.Universo = (Universo)cboUniverso.SelectedItem;

                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.
                if (heroeLocal.Id != 0)
                {
                    negocio.modificarHeroe(heroeLocal);
                }
                else
                {
                    negocio.agregarHeroe(heroeLocal);
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaSuperheroe_Load(object sender, EventArgs e)
        {
            //MSF-20190420: así cargábamos antes los universos, a mano, 2. Ahora lo hace directo desde DB.
            /*Universo uni1 = new Universo();
            Universo uni2 = new Universo();

            uni1.Id = 1;
            uni1.Nombre = "Marvel";
            uni2.Id = 2;
            uni2.Nombre = "DC";
            List<Universo> listaUniversos = new List<Universo>();
            listaUniversos.Add(uni1);
            listaUniversos.Add(uni2);*/

            UniversoNegocio universoNegocio = new UniversoNegocio();

            try
            {
                cboUniverso.DataSource = universoNegocio.listarUniversos();

                //Opcional para combos
                //cboUniverso.DisplayMember = "Nombre";
                //cboUniverso.ValueMember = "Id";

                if (heroeLocal != null)
                {
                    txtNombre.Text = heroeLocal.Nombre;
                    txtDebilidad.Text = heroeLocal.Debilidad;
                    ckbCapa.Checked = heroeLocal.UsaCapa;
                    ckbVuela.Checked = heroeLocal.Volador;
                    cboUniverso.SelectedIndex = cboUniverso.FindString(heroeLocal.Universo.Nombre);

                    //alternativa al retomar una modificacion. Si tenes configurado Display y Value Member
                    //cboUniverso.SelectedValue = heroeLocal.Universo.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

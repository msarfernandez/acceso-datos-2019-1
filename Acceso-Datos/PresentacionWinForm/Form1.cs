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

namespace PresentacionWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HeroeNegocio negocio = new HeroeNegocio();
            try
            {
                dgvPersonajes.DataSource = negocio.listarHeroes();
                dgvPersonajes.Columns[0].Visible = false;
                dgvPersonajes.Columns[3].Visible = false;
                dgvPersonajes.Columns[4].Visible = false;
                dgvPersonajes.Columns[5].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaSuperheroe alta = new frmAltaSuperheroe();
            alta.Show();
        }
    }
}

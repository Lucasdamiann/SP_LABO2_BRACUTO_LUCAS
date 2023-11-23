using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Archivos;
using Entidades.BaseDeDatos;
using Entidades.Modelos;

namespace VideoClub
{
    public partial class frmMenu : Form
    {
        private bool admin = false;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnRegistrosNuevo_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                frmRegistro registro = new frmRegistro();
                registro.ShowDialog();
            });
            t.Start();
        }

        private void btnRegistrosClientes_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                frmClientesRegistrados clientes = new frmClientesRegistrados();
                clientes.ShowDialog();
            });
            t.Start();
        }

        private void btnRegistrosSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistros_Load(object sender, EventArgs e)
        {

        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                frmTienda tienda = new frmTienda();
                tienda.ShowDialog();
            });
            t.Start();
        }
    }
}

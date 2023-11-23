using Entidades.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistroRegistrar_Click(object sender, EventArgs e)
        {
            GestorSqlClientes.GenerarAltaCliente(txtRegistroNombre.Text, txtRegistroApellido.Text, txtRegistroDireccion.Text);
            this.Close();
        }
    }
}

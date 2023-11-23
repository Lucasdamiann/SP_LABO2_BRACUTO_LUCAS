using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.BaseDeDatos;

namespace VideoClub
{
    public partial class frmClientesRegistrados : Form
    {
        public frmClientesRegistrados()
        {
            InitializeComponent();
        }

        private void lblClientesRegistrados_Click(object sender, EventArgs e)
        {

        }

        private void lstClientesRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClientesRegistradosSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientesRegistradosObtener_Click(object sender, EventArgs e)
        {
            lstClientesRegistrados.Items.Clear();
            List<Cliente> clientes = new List<Cliente>();
            clientes = GestorSqlClientes.ObtenerClientes();
            for (int i = 0; i < clientes.Count; i++)
            {
                lstClientesRegistrados.Items.Add((clientes[i].NombreCliente, clientes[i].ApellidoCliente, clientes[i].DireccionCliente).ToString().Replace("(", "").Replace(")", ""));
            }
        }

        private void btnClientesRegistradosBuscar_Click(object sender, EventArgs e)
        {
            Cliente clienteBuscado = new Cliente();
            clienteBuscado = GestorSqlClientes.ObtenerClientePorCampo(txtClientesRegistradosBuscar.Text);
            lstClientesRegistrados.Items.Clear();
            lstClientesRegistrados.Items.Add((clienteBuscado.NombreCliente,clienteBuscado.ApellidoCliente,clienteBuscado.DireccionCliente).ToString().Replace("(", "").Replace(")", ""));
        }
    }
}

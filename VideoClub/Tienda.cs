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
using Entidades.Archivos;
using Entidades.BaseDeDatos;
using Microsoft.VisualBasic;


namespace VideoClub
{
    public partial class frmTienda : Form
    {
        List<string> titulos = new List<string>();
        public frmTienda()
        {
            this.InitializeComponent();
        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            Archivos.CrearRutaArchivo();
            Archivos.SerializarClientes(GestorSqlClientes.ObtenerClientes());
        }

        private void rdbNES_CheckedChanged(object sender, EventArgs e)
        {
            this.CompletarListbox("titulos_nintendo.txt");
        }

        private void rdbSega_CheckedChanged(object sender, EventArgs e)
        {
            this.CompletarListbox("titulos_sega.txt");
        }

        private void rdbPlayStation_CheckedChanged(object sender, EventArgs e)
        {
            this.CompletarListbox("titulos_playstation.txt");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompletarListbox(string nombreArchivo)
        {
            this.lstTitulos.Items.Clear();
            string[] todosLosTitulos = Archivos.CargarArchivo(nombreArchivo).Split(',');
            foreach (var titulo in todosLosTitulos)
            {
                this.lstTitulos.Items.Add(titulo);
            }
        }

        private void ptbPortada_Click(object sender, EventArgs e)
        {

        }

        private void lstTitulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstTitulos.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < lstTitulos.Items.Count)
            {
                if (lstTitulos.SelectedItem is not null)
                {
                    string textoSeleccionado = lstTitulos.Text.ToLower().Replace(' ', '-');
                    string imageName = $"feat-{textoSeleccionado}.jpg";
                    string ruta = "..\\..\\..\\Properties\\Resources\\";
                    string imagePath = Path.Combine(Application.StartupPath, ruta, imageName);
                    if (File.Exists(imagePath))
                    {
                        ptbPortada.Image = Image.FromFile(imagePath);
                    }
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Titulo titulo = new Titulo();
            //string mensaje = titulo.ComprarTitulo();
            //MessageBox.Show(mensaje);
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstTitulos.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < lstTitulos.Items.Count)
            {
                if (lstTitulos.SelectedItem is not null)
                {
                    Titulo titulo = new Titulo();
                    string cantidad = Interaction.InputBox("Cantidad de dias de alquiler:", "Alquiler de titulo", "Ingresar dias");
                    if (int.TryParse(cantidad, out int value))
                    {
                        MessageBox.Show(titulo.AlquilarTitulo(value));
                    }
            
                }
            }
        }
    }
}

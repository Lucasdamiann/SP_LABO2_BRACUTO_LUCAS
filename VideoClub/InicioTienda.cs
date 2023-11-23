using Entidades.BaseDeDatos;
using Entidades.Excepciones;

namespace VideoClub
{
    public partial class FrmInicioTienda : Form
    {
        public FrmInicioTienda()
        {
            this.InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string claveUsuario = txtContraseña.Text;
            try
            {
                if (GestorSqlUsuarios.IniciarSesionUsuario(nombreUsuario, claveUsuario))
                {
                    frmMenu frmRegistros = new frmMenu();
                    this.Hide();
                    frmRegistros.Show();
                }
            }
            catch (UsuarioInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "ERRORsaa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CantidadCaracteresInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex) 
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTienda_Load(object sender, EventArgs e)
        {
        }
    }
}
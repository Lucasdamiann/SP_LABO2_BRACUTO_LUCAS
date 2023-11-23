namespace Entidades.Modelos
{
    public class Cliente
    {
        private int numeroCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private string direccionCliente;
        private List<Titulo> titulosElegidos;

        public Cliente()
        {
            
        }

        public Cliente(int numeroCliente, string nombreCliente, string apellidoCliente, string direccionCliente)
        {
            this.numeroCliente = numeroCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.direccionCliente = direccionCliente;
        }

        public int NumeroCliente { get => this.numeroCliente; set => this.numeroCliente = value; }
        public string NombreCliente { get => this.nombreCliente; set => this.nombreCliente = value; }
        public string ApellidoCliente { get => this.apellidoCliente; set => this.apellidoCliente = value; }
        public string DireccionCliente { get => this.direccionCliente; set => this.direccionCliente = value; }

        public string MostrarPersona()
        {
            return $"{this.NombreCliente}, {this.ApellidoCliente}, {this.DireccionCliente}";
        }

        private void ComprarTitulo()
        {
            
        }
    }
}
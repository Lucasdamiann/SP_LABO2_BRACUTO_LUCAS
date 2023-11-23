namespace Entidades.Modelos
{
    public class Titulo : Consola
    {
        private List<Titulo> nombreTitulo;
        static int stockVenta;
        static int stockAlquiler;
        private string consola;
        static double costoCompra;
        static double costoAlquiler;

        static Titulo()
        {
            Titulo.stockVenta = 3;
            Titulo.stockAlquiler = 4;
            Titulo.costoCompra = 60;
            Titulo.costoAlquiler = 3;
        }

        public string ComprarTitulo(int cantidad)
        {
            if (Titulo.stockVenta > 0)
            {
                Titulo.costoCompra *= cantidad;
                Titulo.stockVenta--;
                return $"Compra exitosa. El costo es {costoCompra} y quedan {stockVenta} unidades en stock";
            }
            else
            {
                return $"Compra fallida. Quedan {stockVenta} unidades en stock";
            }
        }

        public string AlquilarTitulo(int cantidad)
        {
            if (Titulo.stockAlquiler > 0)
            {
                Titulo.costoAlquiler *= cantidad;
                Titulo.stockAlquiler--;
                return $"Alquiler exitoso. El costo es {costoAlquiler} y quedan {stockAlquiler} unidades en stock";
            }
            else
            {
                return $"Alquiler fallido. Quedan {stockAlquiler} unidades en stock";
            }
        }
    }
}

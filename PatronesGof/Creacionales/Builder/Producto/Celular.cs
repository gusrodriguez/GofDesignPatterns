using System.Text;

namespace DesignPatterns.Creacionales.Builder.Producto
{
    /// <summary>
    /// En general en el patrón builder no hay producto abstracto debido a la diferencia que existe entre todos los productos. 
    /// </summary>
    public class Celular
    {
        //El objeto celular es complejo de ser construido.
        public Pantalla Pantalla { get; set; }
        public Teclado Teclado { get; set; }
        public Cargador Cargador { get; set; }

        public string MostrarCaracteristicas()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Empty);
            sb.AppendLine(string.Empty);
            sb.AppendLine("Pantalla: " + this.Pantalla.MostrarCaracteristicas());
            sb.AppendLine("Teclado: " + this.Teclado.MostrarCaracteristicas());
            sb.AppendLine("Cargador: " + this.Cargador.MostrarCaracteristicas());                        

            return sb.ToString();
        }
    }
}

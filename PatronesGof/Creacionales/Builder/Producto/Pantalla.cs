namespace DesignPatterns.Creacionales.Builder.Producto
{
    /// <summary>
    /// Componente del objeto complejo Celular
    /// </summary>
    public class Pantalla
    {
        string caracteristicas;

        public Pantalla(string caracteristicas)
        {
            this.caracteristicas = caracteristicas;
        }

        public string MostrarCaracteristicas()
        {
            return this.caracteristicas;
        }
    }
}

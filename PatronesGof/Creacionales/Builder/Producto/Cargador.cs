namespace DesignPatterns.Creacionales.Builder.Producto
{
    /// <summary>
    /// Componente del objeto complejo Celular
    /// </summary>
    public class Cargador
    {
        string caracteristicas;

        public Cargador(string caracteristicas)
        {
            this.caracteristicas = caracteristicas;
        }

        public string MostrarCaracteristicas()
        {
            return this.caracteristicas;
        }
    }
}

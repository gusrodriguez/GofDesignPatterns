namespace DesignPatterns.Creational.Builder.Producto
{
    /// <summary>
    /// Componente del objeto complejo Celular
    /// </summary>
    public class Teclado
    {
        string _caracteristicas;
        public Teclado(string caracteristicas)
        {
            this._caracteristicas = caracteristicas;
        }

        public string MostrarCaracteristicas()
        {
            return this._caracteristicas;
        }
    }
}

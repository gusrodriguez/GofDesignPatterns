using DesignPatterns.Creacionales.Builder.Producto;
using DesignPatterns.Creational.Builder;

namespace DesignPatterns.Creacionales.Builder.Director
{
    /// <summary>
    /// Director
    /// </summary>
    public class CompaniaCelular
    {
        /// <summary>
        /// Especifica el algoritmo de pasos abstractos de construcción del objeto Celular
        /// </summary>
        /// <param name="celularBuilder"></param>
        public void Construir(CelularBuilder celularBuilder)
        {
            celularBuilder.Celular = new Celular();

            celularBuilder.ConstruirPantalla();
            celularBuilder.ConstruirTeclado();
            celularBuilder.ConstruirCargador();
        }
    }
}

namespace DesignPatterns.Structural.Observer
{
    public class Etiqueta: IEtiquetaObserver
    {
        /// <summary>
        /// Las Etiquetas son observadores del Modelo (Calculadora)
        /// </summary>
        public double Valor { get; set; }

        public void Actualizar(Calculadora calculadora)
        {
            Valor = calculadora.Resultado;
        }
    }
}

namespace DesignPatterns.Structural.Observer
{
    public interface IEtiquetaObserver
    {
        double Valor { get; set; }

        void Actualizar(Calculadora calculadora);
    }
}

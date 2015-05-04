using System.Collections.Generic;

namespace DesignPatterns.Structural.Observer
{
    public class Calculadora
    {
        protected double resultado;

        protected List<IEtiquetaObserver> observadores;

        public Calculadora()
        {
            observadores = new List<IEtiquetaObserver>();
        }

        public void AgregarObservador(IEtiquetaObserver observador)
        {
            observadores.Add(observador);
        }

        public void RemoverObservador(IEtiquetaObserver observador)
        {
            observadores.Remove(observador);
        }

        public double Resultado
        {
            get
            {
                return resultado;
            }
        }
    }
}

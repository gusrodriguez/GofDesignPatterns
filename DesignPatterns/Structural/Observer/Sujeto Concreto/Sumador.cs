namespace DesignPatterns.Structural.Observer
{
    public class Sumador: Calculadora
    {
        public Sumador(): base()
        {            
        }

        /// <summary>
        /// Cuando el modelo (Sumador/Calculadora) cambia de estado, se notifican a todos sus observadores para que cambien su estado tambien
        /// </summary>
   
        public void Sumar(double valor1, double valor2)
        {
            resultado = valor1 + valor2;

            NotificarObservadores();
        }

        public void NotificarObservadores()
        {
            //Observador = etiqueta
            foreach (IEtiquetaObserver observador in observadores)
            {
                observador.Actualizar(this);
            }
        }
    }
}

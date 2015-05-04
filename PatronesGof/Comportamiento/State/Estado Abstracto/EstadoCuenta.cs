using DesignPatterns.Comportamiento.State.Contexto;

namespace DesignPatterns.Behavioral.State
{
    abstract class EstadoCuenta
    {
        //El estado de cuenta conoce a la cuenta corriente
        public CuentaCorriente cuentaCorriente { get; set; }   
        public double Saldo { get; set; }        

        public abstract void Depositar(double importe);
        public abstract void Extraer(double importe);        
    }
}

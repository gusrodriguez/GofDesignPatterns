using System;
using DesignPatterns.Comportamiento.State.Contexto;

namespace DesignPatterns.Behavioral.State
{
    class Normal : EstadoCuenta
    {
        //El estado Normal tiene un constructor sobrecargado porque es el único que se puede inicializar en cero y con una cuenta corriente vacía desde el contexto
        public Normal(CuentaCorriente cuentaCorriente)
        {
            this.cuentaCorriente = cuentaCorriente;
        }        

        public override void Depositar(double importe)
        {
            if (importe <= 1000)
            {
                this.cuentaCorriente.saldo += importe;

                ChequearCambioEstado();
            }
            else
            {
                throw new Exception("No puede despositar más de 1000 pesos por vez");
            }
        }

        public override void Extraer(double importe)
        {            
            this.Saldo -= importe;

            ChequearCambioEstado();            
        }

        public void ChequearCambioEstado()
        {
            //Del estado Normal, pasa a Rojo si tiene saldo negativo
            if (this.cuentaCorriente.saldo < 0)
                this.cuentaCorriente.SetEstado(new Rojo(this.cuentaCorriente));    
            
            //Del estado Normal, pasa a Saturado si tiene más de 10000 pesos de saldo
            if (this.cuentaCorriente.saldo > 10000)
                this.cuentaCorriente.SetEstado(new Saturado(this.cuentaCorriente));  
        }
    }
}

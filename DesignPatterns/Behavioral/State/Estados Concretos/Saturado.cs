using System;

using DesignPatterns.Behavioral.State.Contexto;

namespace DesignPatterns.Behavioral.State
{
    class Saturado : EstadoCuenta
    {
        public Saturado(CuentaCorriente cuentaCorriente)
        {
            this.cuentaCorriente = cuentaCorriente;
        }       

        public override void Depositar(double importe)
        {
            throw new Exception("No se puede depositar dinero en una cuenta saturada");        
        }

        public override void Extraer(double importe)
        {
            this.cuentaCorriente.saldo -= importe;
            ChequearCambioEstado();            
        }

        public void ChequearCambioEstado()
        {
            //Del estado Saturado  puede pasar al estado Normal o a Rojo
            if (this.cuentaCorriente.saldo <= 10000)
            {
                if (this.Saldo < 0)
                {
                    this.cuentaCorriente.SetEstado(new Rojo(this.cuentaCorriente));
                }
                else
                {
                    this.cuentaCorriente.SetEstado(new Normal(this.cuentaCorriente));
                }
            }
        }
    }
}

using System;

using DesignPatterns.Behavioral.State.Contexto;

namespace DesignPatterns.Behavioral.State
{
    class Rojo : EstadoCuenta 
    {
        public Rojo(CuentaCorriente cuentaCorriente)
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
            throw new Exception("No se puede extraer dinero de una cuenta en rojo");
        }

        public void ChequearCambioEstado()
        {
            //Del estado Rojo solo puede pasar al estado Normal
            if (this.cuentaCorriente.saldo >= 0)
            {
                this.cuentaCorriente.SetEstado(new Normal(this.cuentaCorriente));
            }
        }
    }
}

using DesignPatterns.Comportamiento.Strategy.Contexto;

namespace DesignPatterns.Behavioral.Strategy
{
    class EstrategiaContraataqueBelico : EstrategiaContraataque
    {
        public override string Contraatacar(Pelea pelea)
        {
            //Hacer algo con el contexto

            return "Disparo";
        }
    }
}

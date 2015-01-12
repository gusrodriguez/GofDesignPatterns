using DesignPatterns.Behavioral.Strategy.Contexto;

namespace DesignPatterns.Behavioral.Strategy
{
    class EstrategiaContraataqueFisico : EstrategiaContraataque
    {
        public override string Contraatacar(Pelea pelea)
        {
            //Hacer algo con el contexto

            return "Patada";
        }
    }
}

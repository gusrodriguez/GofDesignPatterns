using DesignPatterns.Creational.Builder.Producto;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Builder concreto
    /// </summary>
    class AtrixBuilder : CelularBuilder
    {
        public override void ConstruirPantalla()
        {
            Celular.Pantalla = new Pantalla("Pantalla de Atrix");
        }

        public override void ConstruirTeclado()
        {
            Celular.Teclado = new Teclado("Teclado touch de Atrix");
        }

        public override void ConstruirCargador()
        {
            Celular.Cargador = new Cargador("Cargador negro de Atrix");
        }
    }
}

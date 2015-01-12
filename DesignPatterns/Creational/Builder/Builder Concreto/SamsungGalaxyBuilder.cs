using DesignPatterns.Creational.Builder.Producto;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Builder concreto
    /// </summary>
    class SamsungGalaxyBuilder : CelularBuilder
    {
        public override void ConstruirPantalla()
        {
            Celular.Pantalla = new Pantalla("Pantalla de Samsung");
        }

        public override void ConstruirTeclado()
        {
            Celular.Teclado = new Teclado("Teclado touch de Samsung");
        }

        public override void ConstruirCargador()
        {
            Celular.Cargador = new Cargador("Cargador blanco de Samsung");
        }
    }
}

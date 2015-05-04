namespace DesignPatterns.Creational.FactoryMethod
{
    public class GuitarraFactory: InstrumentoFactory
    {
        public override Instrumento Crear()
        {
            return new Guitarra();
        }
    }
}

namespace DesignPatterns.Creational.FactoryMethod
{
    public class PianoFactory:InstrumentoFactory
    {
        public override Instrumento Crear()
        {
            return new Piano();
        }
    }
}

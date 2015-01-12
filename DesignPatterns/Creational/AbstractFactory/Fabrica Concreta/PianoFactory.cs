namespace DesignPatterns.Creational.AbstractFactory
{
    //Fabrica concreta
    public class PianoFactory : InstrumentoFactory
    {
        public override Instrumento Crear()
        {
            return new Piano();
        }
    }
}

namespace DesignPatterns.Creational.AbstractFactory
{
    //Fábrica concreta
    public class GuitarraFactory : InstrumentoFactory
    {
        public override Instrumento Crear()
        {
            return new Guitarra();
        }
    }
}

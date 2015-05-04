namespace DesignPatterns.Creational.AbstractFactory
{
    //Producto concreto
    public class Piano: Instrumento
    {
        public override string Tocar()
        {
            return "tocando el piano";
        }
    }
}

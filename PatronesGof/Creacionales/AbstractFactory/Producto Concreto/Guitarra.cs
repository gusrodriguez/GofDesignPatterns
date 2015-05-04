namespace DesignPatterns.Creational.AbstractFactory
{
    //Producto concreto
    public class Guitarra: Instrumento
    {
        public override string Tocar()
        {
            return "tocando la guitarra";
        }
    }
}

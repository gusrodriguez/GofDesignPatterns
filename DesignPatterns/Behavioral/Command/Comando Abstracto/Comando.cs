namespace DesignPatterns.Behavioral.Command
{
    public abstract class Comando
    {
        public abstract string Ejecutar();

        public abstract string Deshacer();
    }
}

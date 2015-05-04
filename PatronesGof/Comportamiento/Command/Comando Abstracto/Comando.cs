using DesignPatterns.Comportamiento.Command.Receptor;

namespace DesignPatterns.Behavioral.Command
{
    public abstract class Comando
    {
        protected ContenedorTexto receptor;

        protected Comando(ContenedorTexto receptor)
        {
            this.receptor = receptor;
        }

        public abstract void Ejecutar();

        public abstract void Deshacer();
    }
}

using DesignPatterns.Behavioral.Command.Receptor;

namespace DesignPatterns.Behavioral.Command
{
    public class ComandoCortar : Comando
    {
        ContenedorTexto receptor;

        public ComandoCortar(ContenedorTexto contenedorTexto)
        {
            receptor = contenedorTexto;
        }

        public override string Ejecutar()
        {
            receptor.Cortar();

            return receptor.Texto;
        }

        public override string Deshacer()
        {
            receptor.Pegar();

            return receptor.Texto;
        }
    }
}

using DesignPatterns.Behavioral.Command.Receptor;

namespace DesignPatterns.Behavioral.Command
{
    public class ComandoPegar : Comando
    {
        ContenedorTexto receptor;

        public ComandoPegar(ContenedorTexto contenedorTexto)
        {
            receptor = contenedorTexto;
        }

        public override string Ejecutar()
        {
            receptor.Pegar();

            return receptor.Texto;
        }

        public override string Deshacer()
        {
            receptor.Copiar();

            return string.Empty;
        }
    }
}

using DesignPatterns.Behavioral.Command.Receptor;

namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// La implementación de cada método es distinta para cada comando
    /// </summary>
    public class ComandoCopiar: Comando
    {
        ContenedorTexto receptor;

        public ComandoCopiar(ContenedorTexto contenedorTexto)
        {
            receptor = contenedorTexto;
        }

        public override string Ejecutar()
        {
            receptor.Copiar();

            return receptor.Texto;
        }
     
        public override string Deshacer()
        {
            return receptor.Texto;
        }
    }
}

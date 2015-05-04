using DesignPatterns.Comportamiento.Command.Receptor;

namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// La implementación de cada método es distinta para cada Comando
    /// </summary>
    public class ComandoCopiar: Comando
    {
        public ComandoCopiar(ContenedorTexto contenedorTexto) : base(contenedorTexto)
        {
            receptor = contenedorTexto;
        }

        public override void Ejecutar()
        {
            receptor.Copiar();
        }
     
        public override void Deshacer()
        {
           receptor.RestaurarEstadoAnterior();
        }
    }
}

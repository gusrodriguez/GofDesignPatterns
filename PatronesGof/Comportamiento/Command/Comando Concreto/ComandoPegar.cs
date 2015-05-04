using DesignPatterns.Comportamiento.Command.Receptor;

namespace DesignPatterns.Behavioral.Command
{
    public class ComandoPegar : Comando
    {
        public ComandoPegar(ContenedorTexto contenedorTexto) : base(contenedorTexto)
        {
            receptor = contenedorTexto;
        }

        public override void Ejecutar()
        {
            receptor.Pegar();
        }

        public override void Deshacer()
        {
            receptor.RestaurarEstadoAnterior();
        }
    }
}

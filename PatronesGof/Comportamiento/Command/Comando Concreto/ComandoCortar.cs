using DesignPatterns.Comportamiento.Command.Receptor;

namespace DesignPatterns.Behavioral.Command
{
    public class ComandoCortar : Comando
    {
        public ComandoCortar(ContenedorTexto contenedorTexto) : base(contenedorTexto)
        {
            receptor = contenedorTexto;
        }

        public override void Ejecutar()
        {
            receptor.Cortar();
        }

        public override void Deshacer()
        {
            receptor.RestaurarEstadoAnterior();
        }
    }
}

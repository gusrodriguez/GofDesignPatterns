using DesignPatterns.Estructurales.Bridge.Abstraccion;

namespace DesignPatterns.Structural.Bridge
{
    public class ReproductorVideo: ReproductorMultimedia
    {
        /// <summary>
        /// Operación primitiva común para todos los reproductores de video
        /// </summary>
        /// <returns></returns>
        public override string Abrir()
        {
            return "Abriendo archivo de video...";
        }

        public override string Cerrar()
        {
            return "Cerrando archivo de video...";
        }

        /// <summary>
        /// El objeto ReproductorVideoImplementador puede evolucionar y cambiar sus operaciones, y el Reproductor abstracto va a seguir funcionando en forma transparente 
        /// </summary>
        /// <returns></returns>
        public string Reproducir()
        {           
           return this.Implementador.Reproducir();            
        }
    }
}

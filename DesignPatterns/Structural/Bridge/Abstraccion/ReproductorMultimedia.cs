namespace DesignPatterns.Structural.Bridge.Abstraccion
{
    using DesignPatterns.Structural.Bridge.Implementador;

    /// <summary>
    /// Un ReproductorMultimedia representa un reproductor para contenido multimedia genérico.
    /// </summary>
    public abstract class ReproductorMultimedia
    {
        //Son necesarias operaciones primitivas para que su implementador pueda evolucionar sin afectar a la abstracción.
        //EVOLUCIONAR es la keyword. La clave del patrón es que el implementador puede evolucionar sin cambiar su interface, ya que están desacoplados.
        
        //Operación primitiva común para todos los reproductores multimedia. Sea de video o de audio
        public abstract string Abrir();

        //Operación primitiva común para todos los reproductores multimedia. Sea de video o de audio
        public abstract string Cerrar();

        public ReproductorMultimediaImplementador Implementador;
    }
}

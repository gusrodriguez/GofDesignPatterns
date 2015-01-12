using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Target;

namespace DesignPatterns.Structural.Adapter.Adapter
{
    /// <summary>
    /// Clase que adapta la libreria de tercerps (GPS) al cliente.
    /// </summary>
    public  class DispositivoConGps: Dispositivo
    {
        //La clase Adapter compone al objeto que quiere adaptar
        readonly Gps gpsTerceros;

        public DispositivoConGps()
        {
            this.gpsTerceros = new Gps();
        }

        public override string MostrarGeoLocalizacion()
        {
            var geoPoint = this.gpsTerceros.GetLocation();

            return string.Concat(geoPoint.Lat, " - ", geoPoint.Long);
        }
    }
}

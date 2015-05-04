using DesignPatterns.Estructurales.Adapter.Adaptee;
using DesignPatterns.Estructurales.Adapter.Target;

namespace DesignPatterns.Estructurales.Adapter.Adapter
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

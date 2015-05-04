namespace DesignPatterns.Estructurales.Adapter.Adaptee
{
    /// <summary>
    /// Una librería encapsulada, supongamos de terceros, que proporciona la Geolocalización de un dispositivo.
    /// </summary>
    public class Gps
    {
        public GeoPoint GetLocation()
        {
            //Suponemos que la librería devuelve un tipo de dato no compatible con nuestro modelo de negocio
            return new GeoPoint(200, 200);
        }
    }

    public class GeoPoint
    {
        public GeoPoint(int lat, int long1)
        {
            this.Lat = lat;
            this.Long = long1;
        }

        public int Lat{get;set;}
        public int Long{get;set;}
    }
}

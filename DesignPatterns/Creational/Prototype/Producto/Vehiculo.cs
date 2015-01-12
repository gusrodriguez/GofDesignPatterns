namespace DesignPatterns.Creational.Prototype.Producto
{
    using DesignPatterns.Creational.Prototype.Prototipo;

    public class Vehiculo: PrototipoVehiculo
    {
        private int numeroRuedas;
        private int numeroPuertas;
        
        public int NumeroRuedas
        {
            get
            {
                return this.numeroRuedas;
            }
            set
            {
                this.numeroRuedas = value;
            }
        }

        public int NumeroPuertas
        {
            get
            {
                return this.numeroPuertas;
            }
            set
            {
                this.numeroPuertas = value;
            }
        }

        /// <summary>
        /// Clona al objeto que estará en el diccionario del gestor de prototipos
        /// </summary>
        /// <returns></returns>
        public override Vehiculo Clonar()
        {
            return (Vehiculo)this.MemberwiseClone();
        }
    }
}

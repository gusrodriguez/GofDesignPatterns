using System.Collections.Generic;
using DesignPatterns.Creacionales.Prototype.Producto;

namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Gestiona los prototipos disponibles en un diccionario
    /// </summary>
    public class GestorPrototiposVehiculo
    {
        //Propiedades
        private Dictionary<string, Vehiculo> vehiculos;

        public Dictionary<string, Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        //Constructor
        public GestorPrototiposVehiculo()
        {
            this.vehiculos = new Dictionary<string, Vehiculo>();
        }

        /// <summary>
        /// Agrega un nuevo prototipo
        /// </summary>
        public void AgregarPrototipo(string clave, int numeroRuedas, int numeroPuertas)
        {
            var vehiculo = new Vehiculo();
            
            vehiculo.NumeroRuedas = numeroRuedas;
            vehiculo.NumeroPuertas = numeroPuertas;

            this.vehiculos.Add(clave, vehiculo);
        }       
    }
}

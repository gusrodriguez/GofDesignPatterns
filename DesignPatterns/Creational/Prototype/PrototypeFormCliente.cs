using System;
using System.Windows.Forms;

namespace DesignPatterns.Creational.Prototype
{
    using DesignPatterns.Creational.Prototype.Producto;

    public partial class PrototypeFormCliente : Form
    {
        //Gestor de prototipos como una propiedad del formulario, para que sea global
        private GestorPrototiposVehiculo gestorPrototipos;

        public PrototypeFormCliente()
        {
            InitializeComponent();
            CargarGestorPrototipos();
        }

        /// <summary>
        /// Agrega los prototipos disponibles para que sean clonados. Cada prototipo "reemplaza" a una subclase de la clase vehículo.
        /// </summary>
        private void CargarGestorPrototipos()
        {
            gestorPrototipos = new GestorPrototiposVehiculo();            
            
            //Agregar prototipos al gestor evita la explosión de subclases para la clase Vehículo. Se puede extender en prototipos sin extenderse en clases.
            gestorPrototipos.AgregarPrototipo("sedan", 4, 4);
            gestorPrototipos.AgregarPrototipo("moto", 2, 0);
            gestorPrototipos.AgregarPrototipo("coupe", 4, 2);
        }

        private void btnCrearAuto_Click(object sender, EventArgs e)
        {
            //El cliente conoce el prototipo, pero no existe la subclase "sedan".
            Vehiculo sedan = gestorPrototipos.Vehiculos["sedan"].Clonar();

            MessageBox.Show(string.Concat("Se ha instanciado un nuevo sedan que tiene ", sedan.NumeroPuertas, " puertas y ", sedan.NumeroRuedas, " ruedas"));
        }

        private void btnCrearCoupe_Click(object sender, EventArgs e)
        {
            Vehiculo coupe = gestorPrototipos.Vehiculos["coupe"].Clonar();

            MessageBox.Show(string.Concat("Se ha instanciado una nueva coupe que tiene ", coupe.NumeroPuertas, " puertas y ", coupe.NumeroRuedas, " ruedas"));
        }

        private void btnCrearMoto_Click(object sender, EventArgs e)
        {
            Vehiculo moto = gestorPrototipos.Vehiculos["moto"].Clonar();

            MessageBox.Show(string.Concat("Se ha instanciado una nueva moto que tiene ", moto.NumeroPuertas, " puertas y ", moto.NumeroRuedas, " ruedas"));
        }     
    }
}

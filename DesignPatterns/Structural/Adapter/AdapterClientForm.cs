using System;
using System.Windows.Forms;
using DesignPatterns.Structural.Adapter.Adapter;
using DesignPatterns.Structural.Adapter.Target;

namespace DesignPatterns.Structural.Adapter
{
    public partial class AdapterClientForm : Form
    {
        /// <summary>
        /// Convierte la interface de una clase (GPS) a otra clase utilizada por el cliente (Dispositivo)
        /// </summary>
        public AdapterClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //El cliente instancia a la subclase adapter.
            Dispositivo movil = new DispositivoConGps();

            MessageBox.Show(movil.MostrarGeoLocalizacion());
        }
    }
}

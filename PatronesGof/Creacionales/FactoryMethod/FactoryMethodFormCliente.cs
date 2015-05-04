using System;
using System.Windows.Forms;
using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Creacionales.FactoryMethod
{
    public partial class FactoryMethodFormCliente : Form
    {
        public FactoryMethodFormCliente()
        {
            InitializeComponent();
        }

        private void btnGuitarra_Click(object sender, EventArgs e)
        {
            GuitarraFactory factory = new GuitarraFactory();
            Instrumento instrumento = factory.Crear();

            TocarInstrumento(instrumento);
        }

        private void btnPiano_Click(object sender, EventArgs e)
        {
            PianoFactory factory = new PianoFactory();
            Instrumento instrumento = factory.Crear();

            TocarInstrumento(instrumento);
        }

        private void TocarInstrumento(Instrumento instrumento)
        {
            MessageBox.Show(instrumento.Tocar());
        }
    }
}

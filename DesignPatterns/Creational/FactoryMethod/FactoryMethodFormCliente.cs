using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Creational.FactoryMethod
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

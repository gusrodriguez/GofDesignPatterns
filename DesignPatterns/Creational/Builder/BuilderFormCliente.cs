using System;
using System.Windows.Forms;

namespace DesignPatterns.Creational.Builder
{
    using DesignPatterns.Creational.Builder.Director;

    public partial class BuilderFormCliente : Form
    {
        CompaniaCelular companiaCelular;
        CelularBuilder builder;

        public BuilderFormCliente()
        {
            InitializeComponent();

            //Instancia el director
            companiaCelular = new CompaniaCelular();           
        }

        private void btnConstruirIPhone_Click(object sender, EventArgs e)
        {
            //Instancia el builder concreto. En este punto el cliente lo conoce.
            builder = new SamsungGalaxyBuilder();

            //El director no conoce el builder concreto.
            companiaCelular.Construir(builder);

            //El builder no sabe qué objeto concreto construyó y contiene
            MessageBox.Show(string.Concat("- Caracteristicas del iPhone - ", builder.Celular.MostrarCaracteristicas()));
        }

        private void btnConstruirAtrix_Click(object sender, EventArgs e)
        {
            //Instancia el builder concreto. En este punto el cliente lo conoce.
            builder = new AtrixBuilder();

            //El director no conoce el builder concreto.
            companiaCelular.Construir(builder);

            //El builder no sabe qué objeto concreto construyó y contiene
            MessageBox.Show(string.Concat("- Caracteristicas del Atrix - ", builder.Celular.MostrarCaracteristicas()));
        }

        private void btnConstruirNokia_Click(object sender, EventArgs e)
        {
            //Instancia el builder concreto. En este punto el cliente lo conoce.
            builder = new NokiaN9Builder();

            //El director no conoce el builder concreto.
            companiaCelular.Construir(builder);

            //El builder no sabe qué objeto concreto construyó y contiene
            MessageBox.Show(string.Concat("- Caracteristicas del Nokia N9 - ", builder.Celular.MostrarCaracteristicas()));
        }
    }
}

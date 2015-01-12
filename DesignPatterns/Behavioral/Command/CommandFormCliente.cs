using System;
using System.Windows.Forms;

using DesignPatterns.Behavioral.Command.Invocador;
using DesignPatterns.Behavioral.Command.Receptor;


namespace DesignPatterns.Behavioral.Command
{
    public partial class CommandFormCliente : Form
    {
        //Invocador
        Invocador.Menu menu;

        //Receptor
        ContenedorTexto contenedorTexto;

        public CommandFormCliente()
        {
            InitializeComponent();

            contenedorTexto = new ContenedorTexto();

            menu = new Invocador.Menu(contenedorTexto);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            contenedorTexto.Texto = txt.Text;

            txt.Text = menu.EjecutarOpcion(Opciones.Copiar);
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            contenedorTexto.Texto = txt.Text;

            txt.Text = menu.EjecutarOpcion(Opciones.Cortar);
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            contenedorTexto.Texto = txt.Text;

            txt.Text += menu.EjecutarOpcion(Opciones.Pegar);
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            txt.Text = menu.Deshacer();
        }
    }
}

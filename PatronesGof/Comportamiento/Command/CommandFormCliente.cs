using System;
using System.Windows.Forms;
using DesignPatterns.Behavioral.Command;

namespace DesignPatterns.Comportamiento.Command
{
    public partial class CommandFormCliente : Form
    {
        //Invocador
        Invocador.Menu menu;

        //El receptor es el usercontrol llamado contenedorTexto presente en el form

        public CommandFormCliente()
        {
            InitializeComponent();

            menu = new Invocador.Menu();
        }

        private void copiarMenuItem_Click(object sender, EventArgs e)
        {
            menu.Ejecutar(new ComandoCopiar(contenedorTexto));
        }

        private void cortarMenuItem_Click(object sender, EventArgs e)
        {
            menu.Ejecutar(new ComandoCortar(contenedorTexto));
        }

        private void pegarMenuItem_Click(object sender, EventArgs e)
        {
            menu.Ejecutar(new ComandoPegar(contenedorTexto));
        }
    }
}

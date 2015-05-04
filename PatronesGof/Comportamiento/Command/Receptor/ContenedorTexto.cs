using System.Windows.Forms;

namespace DesignPatterns.Comportamiento.Command.Receptor
{
    public partial class ContenedorTexto : UserControl
    {
        private string estadoAnterior;

        public ContenedorTexto()
        {
            InitializeComponent();

            lstComandosEjecutados.View = View.List;
        }

        public void Copiar()
        {
            LimpiarError();

            if (!string.IsNullOrEmpty(textbox.Text.Trim()))
            {
                GuardarEstadoAnterior();

                AgregarComandoALista("Copiar");

                Clipboard.SetText(textbox.Text, TextDataFormat.Text);
            }
            else
            {
                MostrarError();
            }
        }

        public void Pegar()
        {
            LimpiarError();

            if (!string.IsNullOrEmpty(textbox.Text.Trim()))
            {
                GuardarEstadoAnterior();

                AgregarComandoALista("Pegar");

                textbox.Text = Clipboard.GetText();
            }
            else
            {
                MostrarError();
            }
        }

        public void Cortar()
        {
            LimpiarError();

            if (!string.IsNullOrEmpty(textbox.Text.Trim()))
            {
                GuardarEstadoAnterior();

                AgregarComandoALista("Cortar");

                Clipboard.SetText(textbox.Text, TextDataFormat.Text);

                textbox.Text = string.Empty;
            }
            else
            {
                MostrarError();
            }
        }

        private void GuardarEstadoAnterior()
        {
            estadoAnterior = textbox.Text;
        }

        public void AgregarComandoALista(string tipoComando)
        {
            lstComandosEjecutados.Items.Add(new ListViewItem("Se ejecutó el comando " + tipoComando));
        }

        public void RestaurarEstadoAnterior()
        {
            textbox.Text = estadoAnterior;
        }

        private void LimpiarError()
        {
            lblError.Text = string.Empty;
        }

        private void MostrarError()
        {
            lblError.Text = "Ingrese un texto";
        }
    }
}

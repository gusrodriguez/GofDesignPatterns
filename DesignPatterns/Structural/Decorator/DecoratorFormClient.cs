using System;
using System.Windows.Forms;

using DesignPatterns.Structural.Decorator.Componente;
using DesignPatterns.Structural.Decorator.Decorador;

namespace DesignPatterns.Structural.Decorator
{
    public partial class DecoratorFormClient : Form
    {
        //El objetivo el ejercicio es crear un objeto PersonajeNormal o un objeto PersonajeVolador (decorado), y tratarlos indistintamente desde el cliente.
        Personaje personaje;

        public DecoratorFormClient()
        {
            InitializeComponent();
        }

        private void btnCrearPersonajeNormal_Click(object sender, EventArgs e)
        {
            personaje = new PersonajeNormal();
            lblPersonaje.Text = "Normal";
        }

        private void btnCrearPersonajeVolador_Click(object sender, EventArgs e)
        {
            personaje = new PersonajeVolador();
         
            lblPersonaje.Text = "Volador";
        }       

        private void btnEjecutarHabilidades_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personaje.EjecutarHabilidad());
        }
    }
}

using System;
using System.Windows.Forms;
using DesignPatterns.Structural.Observer;

namespace DesignPatterns.Estructurales.Observer
{
    public partial class ObserverFormClient : Form
    {
         Sumador calculadora;    

         IEtiquetaObserver etiqueta1;
         IEtiquetaObserver etiqueta2;
         IEtiquetaObserver etiqueta3; 

        public ObserverFormClient()
        {
            InitializeComponent();

            //Se instancia el sujeto concreto
            this.calculadora = new Sumador();

            //Se instancian los observadores
            etiqueta1 = new Etiqueta();
            etiqueta2 = new Etiqueta();
            etiqueta3 = new Etiqueta();

            //Se agregan los observadores al sujeto
            this.calculadora.AgregarObservador(etiqueta1);
            this.calculadora.AgregarObservador(etiqueta2);
            this.calculadora.AgregarObservador(etiqueta3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculadora.Sumar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));

            lblTotal1.Text = etiqueta1.Valor.ToString();
            lblTotal2.Text = etiqueta2.Valor.ToString();
            lblTotal3.Text = etiqueta3.Valor.ToString();
        }     
    }
}

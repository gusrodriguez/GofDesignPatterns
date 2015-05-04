using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using DesignPatterns.Behavioral.TemplateMethod;

namespace DesignPatterns.Comportamiento.TemplateMethod
{
    public partial class TemplateMethodFormClient : Form
    {
        public TemplateMethodFormClient()
        {
            InitializeComponent();
            lblListo.Visible = false;
        }      

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            Email email = new Email();

            //Se ejecuta el método plantilla
            ArrayList pasosEnvio = email.Enviar();

            Mostrar(pasosEnvio);          
        }       

        private void btnEnviarSMS_Click(object sender, EventArgs e)
        {
            Sms sms = new Sms();

            //Se ejecuta el método plantilla
            ArrayList pasosEnvio = sms.Enviar();

            Mostrar(pasosEnvio);    
        }      

        private void btnEnviarSeñalHumo_Click(object sender, EventArgs e)
        {
            SeñalDeHumo señalHumo = new SeñalDeHumo();

            //Se ejecuta el método plantilla
            ArrayList pasosEnvio = señalHumo.Enviar();

            Mostrar(pasosEnvio);    
        }

        /// <summary>
        /// Para el efecto delay al mostrar
        /// </summary>
        /// <param name="pasosEnvio"></param>
        private void Mostrar(ArrayList pasosEnvio)
        {           
            lblEnviando.Text = string.Empty;
            
            //Progress bar
            progressBarEnviando.Visible = true;
            progressBarEnviando.Maximum = 100;
            progressBarEnviando.Step = 30;
            progressBarEnviando.Value = 0;

            lblListo.Visible = false;

            foreach (string paso in pasosEnvio)
            {
                lblEnviando.Text += paso + Environment.NewLine;
                progressBarEnviando.Value += 30;
                Application.DoEvents();
                Thread.Sleep(2000);                
            }

            progressBarEnviando.Visible = false;
            lblListo.Visible = true;
        }
    }
}

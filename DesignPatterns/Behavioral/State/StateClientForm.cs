using System;
using System.Windows.Forms;

using DesignPatterns.Behavioral.State.Contexto;

namespace DesignPatterns.Behavioral.State
{
    public partial class StateClientForm : Form
    {
        //Característica del patrón: Hay una referencia circular entre el estado y el contexto. Es decir que el contexto conoce su estado y viceversa.

        //Objetivo: La cuenta corriente cambia su comportamiento dinámicamente según su estado, sin que dicho comportamiento sea seteado por el cliente
        //La clave de este patrón es que la lógica se encuentra en el ESTADO

        private CuentaCorriente cuentaCorriente;

        public StateClientForm()
        {
            InitializeComponent();

            cuentaCorriente = new CuentaCorriente();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                double importe = 0;

                if (Double.TryParse(txtImporte.Text, out importe))
                    cuentaCorriente.Depositar(importe);

                lblSaldo.Text = cuentaCorriente.saldo.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                double importe = 0;

                if (Double.TryParse(txtImporte.Text, out importe))
                {
                    cuentaCorriente.Extraer(importe);
                }

                lblSaldo.Text = cuentaCorriente.saldo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

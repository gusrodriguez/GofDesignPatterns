using System;
using System.Windows.Forms;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Comportamiento.Strategy.Contexto;

namespace DesignPatterns.Comportamiento.Strategy
{

    public partial class StrategyFormClient : Form
    {
        //Contexto para las extrategias
        Pelea pelea;

        public StrategyFormClient()
        {
            pelea = new Pelea();
            InitializeComponent();
        }

        //El cliente debe conocer la estrategia para poder cambiarla
        private void btnAtacarMagia_Click(object sender, EventArgs e)
        {
            //Setea dinámicamente el comportamiento (estrategia) al contexto de la pelea
            pelea.DefinirEstrategiaContraataque(new EstrategiaContraataqueMagico());

            lblEstrategiaContraataque.Text = pelea.Contraatacar();
        }

        //El cliente debe conocer la estrategia para poder cambiarla
        private void btnAtacarGolpe_Click(object sender, EventArgs e)
        {
            //Setea dinámicamente el comportamiento (estrategia) al contexto de la pelea
            pelea.DefinirEstrategiaContraataque(new EstrategiaContraataqueFisico());

            lblEstrategiaContraataque.Text = pelea.Contraatacar();
        }

        //El cliente debe conocer la estrategia para poder cambiarla
        private void btnAtacarArma_Click(object sender, EventArgs e)
        {
            //Setea dinámicamente el comportamiento (estrategia) al contexto de la pelea
            pelea.DefinirEstrategiaContraataque(new EstrategiaContraataqueBelico());

            lblEstrategiaContraataque.Text = pelea.Contraatacar();
        }

        private void StrategyFormClient_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using DesignPatterns.Comportamiento.Command;
using DesignPatterns.Comportamiento.State;
using DesignPatterns.Comportamiento.Strategy;
using DesignPatterns.Comportamiento.TemplateMethod;
using DesignPatterns.Creacionales.AbstractFactory;
using DesignPatterns.Creacionales.Builder;
using DesignPatterns.Creacionales.Prototype;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Estructurales.Adapter;
using DesignPatterns.Estructurales.Bridge;
using DesignPatterns.Estructurales.Decorator;
using DesignPatterns.Estructurales.Observer;
using DesignPatterns.Estructurales.Proxy;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Observer;

namespace DesignPatterns
{
    public partial class Patrones : Form
    {
        public Patrones()
        {
            InitializeComponent();
        }            

        private void abstractFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbstractFactoryFormCliente abstractFactoryForm = new AbstractFactoryFormCliente();
            abstractFactoryForm.Show();
        }

        private void prototypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrototypeFormCliente prototypeForm = new PrototypeFormCliente();
            prototypeForm.Show();
        }

        private void builderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuilderFormCliente builderForm = new BuilderFormCliente();
            builderForm.Show();
        }

        private void templateMethodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TemplateMethodFormClient templateMethodForm = new TemplateMethodFormClient();
            templateMethodForm.Show();
        }

        private void strategyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StrategyFormClient strategyForm = new StrategyFormClient();
            strategyForm.Show();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           StateClientForm stateForm = new StateClientForm();
           stateForm.Show();
        }

        private void compositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CompositeClientForm compositeForm = new CompositeClientForm();
            //compositeForm.Show();
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandFormCliente commandForm = new CommandFormCliente();
            commandForm.Show();
        }

        private void adapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdapterClientForm adapterForm = new AdapterClientForm();
            adapterForm.Show();
        }

        private void decoratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecoratorFormClient decoratorForm = new DecoratorFormClient();
            decoratorForm.Show();
        }

        private void proxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProxyFormClient proxyForm = new ProxyFormClient();
            proxyForm.Show();
        }

        private void bridgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BridgeFormClient brigdeForm = new BridgeFormClient();
            brigdeForm.Show();
        }

        private void observerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObserverFormClient observerForm = new ObserverFormClient();
            observerForm.Show();
        }
    }
}

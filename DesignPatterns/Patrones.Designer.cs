namespace DesignPatterns
{
    partial class Patrones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abstractFactoryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abstractFactoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prototypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prototypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decoratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bridgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.templateMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templateMethodToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.strategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abstractFactoryItem,
            this.prototypeMenuItem,
            this.toolStripMenuItem1,
            this.templateMethodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abstractFactoryItem
            // 
            this.abstractFactoryItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abstractFactoryToolStripMenuItem,
            this.prototypeToolStripMenuItem,
            this.builderToolStripMenuItem});
            this.abstractFactoryItem.Name = "abstractFactoryItem";
            this.abstractFactoryItem.Size = new System.Drawing.Size(66, 20);
            this.abstractFactoryItem.Text = "Creacion";
            // 
            // abstractFactoryToolStripMenuItem
            // 
            this.abstractFactoryToolStripMenuItem.Name = "abstractFactoryToolStripMenuItem";
            this.abstractFactoryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.abstractFactoryToolStripMenuItem.Text = "Abstract Factory";
            this.abstractFactoryToolStripMenuItem.Click += new System.EventHandler(this.abstractFactoryToolStripMenuItem_Click);
            // 
            // prototypeToolStripMenuItem
            // 
            this.prototypeToolStripMenuItem.Name = "prototypeToolStripMenuItem";
            this.prototypeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.prototypeToolStripMenuItem.Text = "Prototype";
            this.prototypeToolStripMenuItem.Click += new System.EventHandler(this.prototypeToolStripMenuItem_Click);
            // 
            // builderToolStripMenuItem
            // 
            this.builderToolStripMenuItem.Name = "builderToolStripMenuItem";
            this.builderToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.builderToolStripMenuItem.Text = "Builder";
            this.builderToolStripMenuItem.Click += new System.EventHandler(this.builderToolStripMenuItem_Click);
            // 
            // prototypeMenuItem
            // 
            this.prototypeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compositeToolStripMenuItem,
            this.adapterToolStripMenuItem,
            this.decoratorToolStripMenuItem,
            this.proxyToolStripMenuItem,
            this.bridgeToolStripMenuItem,
            this.observerToolStripMenuItem});
            this.prototypeMenuItem.Name = "prototypeMenuItem";
            this.prototypeMenuItem.Size = new System.Drawing.Size(75, 20);
            this.prototypeMenuItem.Text = "Estructural";
            // 
            // compositeToolStripMenuItem
            // 
            this.compositeToolStripMenuItem.Name = "compositeToolStripMenuItem";
            this.compositeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.compositeToolStripMenuItem.Text = "Composite";
            this.compositeToolStripMenuItem.Click += new System.EventHandler(this.compositeToolStripMenuItem_Click);
            // 
            // adapterToolStripMenuItem
            // 
            this.adapterToolStripMenuItem.Name = "adapterToolStripMenuItem";
            this.adapterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adapterToolStripMenuItem.Text = "Adapter";
            this.adapterToolStripMenuItem.Click += new System.EventHandler(this.adapterToolStripMenuItem_Click);
            // 
            // decoratorToolStripMenuItem
            // 
            this.decoratorToolStripMenuItem.Name = "decoratorToolStripMenuItem";
            this.decoratorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decoratorToolStripMenuItem.Text = "Decorator";
            this.decoratorToolStripMenuItem.Click += new System.EventHandler(this.decoratorToolStripMenuItem_Click);
            // 
            // proxyToolStripMenuItem
            // 
            this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
            this.proxyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proxyToolStripMenuItem.Text = "Proxy";
            this.proxyToolStripMenuItem.Click += new System.EventHandler(this.proxyToolStripMenuItem_Click);
            // 
            // bridgeToolStripMenuItem
            // 
            this.bridgeToolStripMenuItem.Name = "bridgeToolStripMenuItem";
            this.bridgeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bridgeToolStripMenuItem.Text = "Bridge";
            this.bridgeToolStripMenuItem.Click += new System.EventHandler(this.bridgeToolStripMenuItem_Click);
            // 
            // observerToolStripMenuItem
            // 
            this.observerToolStripMenuItem.Name = "observerToolStripMenuItem";
            this.observerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.observerToolStripMenuItem.Text = "Observer";
            this.observerToolStripMenuItem.Click += new System.EventHandler(this.observerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // templateMethodToolStripMenuItem
            // 
            this.templateMethodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templateMethodToolStripMenuItem1,
            this.strategyToolStripMenuItem,
            this.stateToolStripMenuItem,
            this.commandToolStripMenuItem});
            this.templateMethodToolStripMenuItem.Name = "templateMethodToolStripMenuItem";
            this.templateMethodToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.templateMethodToolStripMenuItem.Text = "Comportamiento";
            // 
            // templateMethodToolStripMenuItem1
            // 
            this.templateMethodToolStripMenuItem1.Name = "templateMethodToolStripMenuItem1";
            this.templateMethodToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.templateMethodToolStripMenuItem1.Text = "Template Method";
            this.templateMethodToolStripMenuItem1.Click += new System.EventHandler(this.templateMethodToolStripMenuItem1_Click);
            // 
            // strategyToolStripMenuItem
            // 
            this.strategyToolStripMenuItem.Name = "strategyToolStripMenuItem";
            this.strategyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.strategyToolStripMenuItem.Text = "Strategy";
            this.strategyToolStripMenuItem.Click += new System.EventHandler(this.strategyToolStripMenuItem_Click);
            // 
            // stateToolStripMenuItem
            // 
            this.stateToolStripMenuItem.Name = "stateToolStripMenuItem";
            this.stateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.stateToolStripMenuItem.Text = "State";
            this.stateToolStripMenuItem.Click += new System.EventHandler(this.stateToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.commandToolStripMenuItem.Text = "Command";
            this.commandToolStripMenuItem.Click += new System.EventHandler(this.commandToolStripMenuItem_Click);
            // 
            // Patrones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 48);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Patrones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patrones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abstractFactoryItem;
        private System.Windows.Forms.ToolStripMenuItem prototypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem templateMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abstractFactoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prototypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templateMethodToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem strategyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compositeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adapterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decoratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bridgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observerToolStripMenuItem;
    }
}
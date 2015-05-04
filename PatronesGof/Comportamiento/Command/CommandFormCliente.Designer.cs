using DesignPatterns.Comportamiento.Command.Receptor;

namespace DesignPatterns.Comportamiento.Command
{
    partial class CommandFormCliente
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
            this.MenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeshacer = new System.Windows.Forms.Label();
            this.contenedorTexto = new DesignPatterns.Comportamiento.Command.Receptor.ContenedorTexto();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuForm
            // 
            this.MenuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarMenuItem,
            this.cortarMenuItem,
            this.pegarMenuItem});
            this.MenuForm.Name = "MenuForm";
            this.MenuForm.Size = new System.Drawing.Size(50, 20);
            this.MenuForm.Text = "Menu";
            this.MenuForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // copiarMenuItem
            // 
            this.copiarMenuItem.Name = "copiarMenuItem";
            this.copiarMenuItem.Size = new System.Drawing.Size(109, 22);
            this.copiarMenuItem.Text = "Copiar";
            this.copiarMenuItem.Click += new System.EventHandler(this.copiarMenuItem_Click);
            // 
            // cortarMenuItem
            // 
            this.cortarMenuItem.Name = "cortarMenuItem";
            this.cortarMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cortarMenuItem.Text = "Cortar";
            this.cortarMenuItem.Click += new System.EventHandler(this.cortarMenuItem_Click);
            // 
            // pegarMenuItem
            // 
            this.pegarMenuItem.Name = "pegarMenuItem";
            this.pegarMenuItem.Size = new System.Drawing.Size(109, 22);
            this.pegarMenuItem.Text = "Pegar";
            this.pegarMenuItem.Click += new System.EventHandler(this.pegarMenuItem_Click);
            // 
            // lblDeshacer
            // 
            this.lblDeshacer.AutoSize = true;
            this.lblDeshacer.Location = new System.Drawing.Point(234, 11);
            this.lblDeshacer.Name = "lblDeshacer";
            this.lblDeshacer.Size = new System.Drawing.Size(0, 13);
            this.lblDeshacer.TabIndex = 7;
            // 
            // contenedorTexto
            // 
            this.contenedorTexto.Location = new System.Drawing.Point(24, 37);
            this.contenedorTexto.Name = "contenedorTexto";
            this.contenedorTexto.Size = new System.Drawing.Size(361, 328);
            this.contenedorTexto.TabIndex = 6;
            // 
            // CommandFormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 374);
            this.Controls.Add(this.lblDeshacer);
            this.Controls.Add(this.contenedorTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CommandFormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommandFormCliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuForm;
        private System.Windows.Forms.ToolStripMenuItem copiarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarMenuItem;
        private Receptor.ContenedorTexto contenedorTexto;
        private System.Windows.Forms.Label lblDeshacer;
    }
}
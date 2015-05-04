namespace DesignPatterns.Estructurales.Decorator
{
    partial class DecoratorFormClient
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
            this.btnCrearMago = new System.Windows.Forms.Button();
            this.btnCrearElfo = new System.Windows.Forms.Button();
            this.btnEjecutarHabilidades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearMago
            // 
            this.btnCrearMago.Location = new System.Drawing.Point(65, 26);
            this.btnCrearMago.Name = "btnCrearMago";
            this.btnCrearMago.Size = new System.Drawing.Size(169, 23);
            this.btnCrearMago.TabIndex = 0;
            this.btnCrearMago.Text = "Crear Personaje Normal";
            this.btnCrearMago.UseVisualStyleBackColor = true;
            this.btnCrearMago.Click += new System.EventHandler(this.btnCrearPersonajeNormal_Click);
            // 
            // btnCrearElfo
            // 
            this.btnCrearElfo.Location = new System.Drawing.Point(240, 26);
            this.btnCrearElfo.Name = "btnCrearElfo";
            this.btnCrearElfo.Size = new System.Drawing.Size(155, 23);
            this.btnCrearElfo.TabIndex = 1;
            this.btnCrearElfo.Text = "Crear Personaje Volador";
            this.btnCrearElfo.UseVisualStyleBackColor = true;
            this.btnCrearElfo.Click += new System.EventHandler(this.btnCrearPersonajeVolador_Click);
            // 
            // btnEjecutarHabilidades
            // 
            this.btnEjecutarHabilidades.Location = new System.Drawing.Point(65, 67);
            this.btnEjecutarHabilidades.Name = "btnEjecutarHabilidades";
            this.btnEjecutarHabilidades.Size = new System.Drawing.Size(330, 23);
            this.btnEjecutarHabilidades.TabIndex = 5;
            this.btnEjecutarHabilidades.Text = "Ejecutar Habilidades";
            this.btnEjecutarHabilidades.UseVisualStyleBackColor = true;
            this.btnEjecutarHabilidades.Click += new System.EventHandler(this.btnEjecutarHabilidades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personaje:";
            // 
            // lblPersonaje
            // 
            this.lblPersonaje.AutoSize = true;
            this.lblPersonaje.Location = new System.Drawing.Point(128, 116);
            this.lblPersonaje.Name = "lblPersonaje";
            this.lblPersonaje.Size = new System.Drawing.Size(94, 13);
            this.lblPersonaje.TabIndex = 7;
            this.lblPersonaje.Text = "Cree un Personaje";
            // 
            // DecoratorFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 151);
            this.Controls.Add(this.lblPersonaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEjecutarHabilidades);
            this.Controls.Add(this.btnCrearElfo);
            this.Controls.Add(this.btnCrearMago);
            this.Name = "DecoratorFormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecoratorFormClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearMago;
        private System.Windows.Forms.Button btnCrearElfo;
        private System.Windows.Forms.Button btnEjecutarHabilidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonaje;
    }
}
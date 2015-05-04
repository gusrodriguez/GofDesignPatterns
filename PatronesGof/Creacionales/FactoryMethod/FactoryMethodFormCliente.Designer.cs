namespace DesignPatterns.Creacionales.FactoryMethod
{
    partial class FactoryMethodFormCliente
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
            this.btnGuitarra = new System.Windows.Forms.Button();
            this.btnPiano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuitarra
            // 
            this.btnGuitarra.Location = new System.Drawing.Point(61, 12);
            this.btnGuitarra.Name = "btnGuitarra";
            this.btnGuitarra.Size = new System.Drawing.Size(170, 23);
            this.btnGuitarra.TabIndex = 0;
            this.btnGuitarra.Text = "Crear y tocar guitarra";
            this.btnGuitarra.UseVisualStyleBackColor = true;
            this.btnGuitarra.Click += new System.EventHandler(this.btnGuitarra_Click);
            // 
            // btnPiano
            // 
            this.btnPiano.Location = new System.Drawing.Point(61, 51);
            this.btnPiano.Name = "btnPiano";
            this.btnPiano.Size = new System.Drawing.Size(170, 23);
            this.btnPiano.TabIndex = 1;
            this.btnPiano.Text = "Crear y tocar piano";
            this.btnPiano.UseVisualStyleBackColor = true;
            this.btnPiano.Click += new System.EventHandler(this.btnPiano_Click);
            // 
            // FactoryMethodFormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.btnPiano);
            this.Controls.Add(this.btnGuitarra);
            this.Name = "FactoryMethodFormCliente";
            this.Text = "FactoryMethodFormCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuitarra;
        private System.Windows.Forms.Button btnPiano;
    }
}
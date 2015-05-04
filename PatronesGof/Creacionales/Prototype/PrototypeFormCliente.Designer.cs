namespace DesignPatterns.Creacionales.Prototype
{
    partial class PrototypeFormCliente
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
            this.btnCrearAuto = new System.Windows.Forms.Button();
            this.btnCrearMoto = new System.Windows.Forms.Button();
            this.btnCrearCoupe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAuto
            // 
            this.btnCrearAuto.Location = new System.Drawing.Point(77, 12);
            this.btnCrearAuto.Name = "btnCrearAuto";
            this.btnCrearAuto.Size = new System.Drawing.Size(140, 30);
            this.btnCrearAuto.TabIndex = 0;
            this.btnCrearAuto.Text = "Crear Sedan";
            this.btnCrearAuto.UseVisualStyleBackColor = true;
            this.btnCrearAuto.Click += new System.EventHandler(this.btnCrearAuto_Click);
            // 
            // btnCrearMoto
            // 
            this.btnCrearMoto.Location = new System.Drawing.Point(77, 48);
            this.btnCrearMoto.Name = "btnCrearMoto";
            this.btnCrearMoto.Size = new System.Drawing.Size(140, 30);
            this.btnCrearMoto.TabIndex = 1;
            this.btnCrearMoto.Text = "Crear Moto";
            this.btnCrearMoto.UseVisualStyleBackColor = true;
            this.btnCrearMoto.Click += new System.EventHandler(this.btnCrearMoto_Click);
            // 
            // btnCrearCoupe
            // 
            this.btnCrearCoupe.Location = new System.Drawing.Point(77, 85);
            this.btnCrearCoupe.Name = "btnCrearCoupe";
            this.btnCrearCoupe.Size = new System.Drawing.Size(140, 28);
            this.btnCrearCoupe.TabIndex = 2;
            this.btnCrearCoupe.Text = "Crear Coupe";
            this.btnCrearCoupe.UseVisualStyleBackColor = true;
            this.btnCrearCoupe.Click += new System.EventHandler(this.btnCrearCoupe_Click);
            // 
            // PrototypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.btnCrearCoupe);
            this.Controls.Add(this.btnCrearMoto);
            this.Controls.Add(this.btnCrearAuto);
            this.Name = "PrototypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrototypeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAuto;
        private System.Windows.Forms.Button btnCrearMoto;
        private System.Windows.Forms.Button btnCrearCoupe;
    }
}
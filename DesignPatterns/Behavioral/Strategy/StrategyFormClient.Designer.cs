namespace DesignPatterns.Behavioral.Strategy
{
    partial class StrategyFormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategyFormClient));
            this.btnAtacarMagia = new System.Windows.Forms.Button();
            this.btnAtacarGolpe = new System.Windows.Forms.Button();
            this.btnAtacarArma = new System.Windows.Forms.Button();
            this.lblAtaqueTitulo = new System.Windows.Forms.Label();
            this.lblEstrategiaContraataque = new System.Windows.Forms.Label();
            this.lblContraataqueTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtacarMagia
            // 
            this.btnAtacarMagia.Location = new System.Drawing.Point(166, 166);
            this.btnAtacarMagia.Name = "btnAtacarMagia";
            this.btnAtacarMagia.Size = new System.Drawing.Size(109, 23);
            this.btnAtacarMagia.TabIndex = 0;
            this.btnAtacarMagia.Text = "Atacar con Magia";
            this.btnAtacarMagia.UseVisualStyleBackColor = true;
            this.btnAtacarMagia.Click += new System.EventHandler(this.btnAtacarMagia_Click);
            // 
            // btnAtacarGolpe
            // 
            this.btnAtacarGolpe.Location = new System.Drawing.Point(166, 195);
            this.btnAtacarGolpe.Name = "btnAtacarGolpe";
            this.btnAtacarGolpe.Size = new System.Drawing.Size(109, 23);
            this.btnAtacarGolpe.TabIndex = 1;
            this.btnAtacarGolpe.Text = "Atacar con Golpe";
            this.btnAtacarGolpe.UseVisualStyleBackColor = true;
            this.btnAtacarGolpe.Click += new System.EventHandler(this.btnAtacarGolpe_Click);
            // 
            // btnAtacarArma
            // 
            this.btnAtacarArma.Location = new System.Drawing.Point(166, 224);
            this.btnAtacarArma.Name = "btnAtacarArma";
            this.btnAtacarArma.Size = new System.Drawing.Size(109, 23);
            this.btnAtacarArma.TabIndex = 2;
            this.btnAtacarArma.Text = "Atacar con Arma";
            this.btnAtacarArma.UseVisualStyleBackColor = true;
            this.btnAtacarArma.Click += new System.EventHandler(this.btnAtacarArma_Click);
            // 
            // lblAtaqueTitulo
            // 
            this.lblAtaqueTitulo.AutoSize = true;
            this.lblAtaqueTitulo.Location = new System.Drawing.Point(163, 25);
            this.lblAtaqueTitulo.Name = "lblAtaqueTitulo";
            this.lblAtaqueTitulo.Size = new System.Drawing.Size(41, 13);
            this.lblAtaqueTitulo.TabIndex = 3;
            this.lblAtaqueTitulo.Text = "Ataque";
            // 
            // lblEstrategiaContraataque
            // 
            this.lblEstrategiaContraataque.AutoSize = true;
            this.lblEstrategiaContraataque.Location = new System.Drawing.Point(371, 176);
            this.lblEstrategiaContraataque.Name = "lblEstrategiaContraataque";
            this.lblEstrategiaContraataque.Size = new System.Drawing.Size(0, 13);
            this.lblEstrategiaContraataque.TabIndex = 4;
            // 
            // lblContraataqueTitulo
            // 
            this.lblContraataqueTitulo.AutoSize = true;
            this.lblContraataqueTitulo.Location = new System.Drawing.Point(371, 24);
            this.lblContraataqueTitulo.Name = "lblContraataqueTitulo";
            this.lblContraataqueTitulo.Size = new System.Drawing.Size(71, 13);
            this.lblContraataqueTitulo.TabIndex = 7;
            this.lblContraataqueTitulo.Text = "Contraataque";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 222);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(458, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 222);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // StrategyFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 259);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblContraataqueTitulo);
            this.Controls.Add(this.lblEstrategiaContraataque);
            this.Controls.Add(this.lblAtaqueTitulo);
            this.Controls.Add(this.btnAtacarArma);
            this.Controls.Add(this.btnAtacarGolpe);
            this.Controls.Add(this.btnAtacarMagia);
            this.Name = "StrategyFormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StrategyFormClient";
            this.Load += new System.EventHandler(this.StrategyFormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtacarMagia;
        private System.Windows.Forms.Button btnAtacarGolpe;
        private System.Windows.Forms.Button btnAtacarArma;
        private System.Windows.Forms.Label lblAtaqueTitulo;
        private System.Windows.Forms.Label lblEstrategiaContraataque;
        private System.Windows.Forms.Label lblContraataqueTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
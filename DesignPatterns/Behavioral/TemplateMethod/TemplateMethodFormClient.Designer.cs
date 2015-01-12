namespace DesignPatterns.Behavioral.TemplateMethod
{
    partial class TemplateMethodFormClient
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
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnEnviarSMS = new System.Windows.Forms.Button();
            this.btnEnviarSeñalHumo = new System.Windows.Forms.Button();
            this.lblEnviando = new System.Windows.Forms.Label();
            this.progressBarEnviando = new System.Windows.Forms.ProgressBar();
            this.lblListo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(71, 12);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(142, 23);
            this.btnEnviarEmail.TabIndex = 0;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnEnviarSMS
            // 
            this.btnEnviarSMS.Location = new System.Drawing.Point(71, 41);
            this.btnEnviarSMS.Name = "btnEnviarSMS";
            this.btnEnviarSMS.Size = new System.Drawing.Size(142, 23);
            this.btnEnviarSMS.TabIndex = 1;
            this.btnEnviarSMS.Text = "Enviar SMS";
            this.btnEnviarSMS.UseVisualStyleBackColor = true;
            this.btnEnviarSMS.Click += new System.EventHandler(this.btnEnviarSMS_Click);
            // 
            // btnEnviarSeñalHumo
            // 
            this.btnEnviarSeñalHumo.Location = new System.Drawing.Point(71, 70);
            this.btnEnviarSeñalHumo.Name = "btnEnviarSeñalHumo";
            this.btnEnviarSeñalHumo.Size = new System.Drawing.Size(142, 23);
            this.btnEnviarSeñalHumo.TabIndex = 2;
            this.btnEnviarSeñalHumo.Text = "Enviar señal de humo";
            this.btnEnviarSeñalHumo.UseVisualStyleBackColor = true;
            this.btnEnviarSeñalHumo.Click += new System.EventHandler(this.btnEnviarSeñalHumo_Click);
            // 
            // lblEnviando
            // 
            this.lblEnviando.AutoSize = true;
            this.lblEnviando.Location = new System.Drawing.Point(68, 135);
            this.lblEnviando.Name = "lblEnviando";
            this.lblEnviando.Size = new System.Drawing.Size(0, 13);
            this.lblEnviando.TabIndex = 3;
            // 
            // progressBarEnviando
            // 
            this.progressBarEnviando.Location = new System.Drawing.Point(71, 215);
            this.progressBarEnviando.Name = "progressBarEnviando";
            this.progressBarEnviando.Size = new System.Drawing.Size(142, 23);
            this.progressBarEnviando.TabIndex = 4;
            this.progressBarEnviando.Visible = false;
            // 
            // lblListo
            // 
            this.lblListo.AutoSize = true;
            this.lblListo.Location = new System.Drawing.Point(71, 247);
            this.lblListo.Name = "lblListo";
            this.lblListo.Size = new System.Drawing.Size(29, 13);
            this.lblListo.TabIndex = 5;
            this.lblListo.Text = "Listo";
            // 
            // TemplateMethodFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.lblListo);
            this.Controls.Add(this.progressBarEnviando);
            this.Controls.Add(this.lblEnviando);
            this.Controls.Add(this.btnEnviarSeñalHumo);
            this.Controls.Add(this.btnEnviarSMS);
            this.Controls.Add(this.btnEnviarEmail);
            this.Name = "TemplateMethodFormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemplateMethodFormClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnEnviarSMS;
        private System.Windows.Forms.Button btnEnviarSeñalHumo;
        private System.Windows.Forms.Label lblEnviando;
        private System.Windows.Forms.ProgressBar progressBarEnviando;
        private System.Windows.Forms.Label lblListo;
    }
}
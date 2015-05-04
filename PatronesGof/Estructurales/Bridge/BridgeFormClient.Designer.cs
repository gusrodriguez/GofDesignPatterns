namespace DesignPatterns.Estructurales.Bridge
{
    partial class BridgeFormClient
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
            this.btnAVI = new System.Windows.Forms.Button();
            this.btnMP4 = new System.Windows.Forms.Button();
            this.txtReproductor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAVI
            // 
            this.btnAVI.Location = new System.Drawing.Point(34, 219);
            this.btnAVI.Name = "btnAVI";
            this.btnAVI.Size = new System.Drawing.Size(88, 23);
            this.btnAVI.TabIndex = 0;
            this.btnAVI.Text = "Reproducir AVI";
            this.btnAVI.UseVisualStyleBackColor = true;
            this.btnAVI.Click += new System.EventHandler(this.btnAVI_Click);
            // 
            // btnMP4
            // 
            this.btnMP4.Location = new System.Drawing.Point(140, 219);
            this.btnMP4.Name = "btnMP4";
            this.btnMP4.Size = new System.Drawing.Size(105, 23);
            this.btnMP4.TabIndex = 1;
            this.btnMP4.Text = "Reproducir MP4";
            this.btnMP4.UseVisualStyleBackColor = true;
            this.btnMP4.Click += new System.EventHandler(this.btnMP4_Click);
            // 
            // txtReproductor
            // 
            this.txtReproductor.BackColor = System.Drawing.Color.Black;
            this.txtReproductor.ForeColor = System.Drawing.Color.White;
            this.txtReproductor.Location = new System.Drawing.Point(34, 25);
            this.txtReproductor.Multiline = true;
            this.txtReproductor.Name = "txtReproductor";
            this.txtReproductor.Size = new System.Drawing.Size(211, 177);
            this.txtReproductor.TabIndex = 2;           
            // 
            // BridgeFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtReproductor);
            this.Controls.Add(this.btnMP4);
            this.Controls.Add(this.btnAVI);
            this.Name = "BridgeFormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BridgeFormClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAVI;
        private System.Windows.Forms.Button btnMP4;
        private System.Windows.Forms.TextBox txtReproductor;
    }
}
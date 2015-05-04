namespace DesignPatterns.Creacionales.Builder
{
    partial class BuilderFormCliente
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
            this.btnConstruirIPhone = new System.Windows.Forms.Button();
            this.btnConstruirAtrix = new System.Windows.Forms.Button();
            this.btnConstruirNokia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConstruirIPhone
            // 
            this.btnConstruirIPhone.Location = new System.Drawing.Point(74, 22);
            this.btnConstruirIPhone.Name = "btnConstruirIPhone";
            this.btnConstruirIPhone.Size = new System.Drawing.Size(136, 23);
            this.btnConstruirIPhone.TabIndex = 0;
            this.btnConstruirIPhone.Text = "Construir iPhone";
            this.btnConstruirIPhone.UseVisualStyleBackColor = true;
            this.btnConstruirIPhone.Click += new System.EventHandler(this.btnConstruirIPhone_Click);
            // 
            // btnConstruirAtrix
            // 
            this.btnConstruirAtrix.Location = new System.Drawing.Point(74, 51);
            this.btnConstruirAtrix.Name = "btnConstruirAtrix";
            this.btnConstruirAtrix.Size = new System.Drawing.Size(136, 23);
            this.btnConstruirAtrix.TabIndex = 1;
            this.btnConstruirAtrix.Text = "Construir Atrix";
            this.btnConstruirAtrix.UseVisualStyleBackColor = true;
            this.btnConstruirAtrix.Click += new System.EventHandler(this.btnConstruirAtrix_Click);
            // 
            // btnConstruirNokia
            // 
            this.btnConstruirNokia.Location = new System.Drawing.Point(74, 80);
            this.btnConstruirNokia.Name = "btnConstruirNokia";
            this.btnConstruirNokia.Size = new System.Drawing.Size(136, 23);
            this.btnConstruirNokia.TabIndex = 2;
            this.btnConstruirNokia.Text = "Construir Nokia N9";
            this.btnConstruirNokia.UseVisualStyleBackColor = true;
            this.btnConstruirNokia.Click += new System.EventHandler(this.btnConstruirNokia_Click);
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btnConstruirNokia);
            this.Controls.Add(this.btnConstruirAtrix);
            this.Controls.Add(this.btnConstruirIPhone);
            this.Name = "BuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuilderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConstruirIPhone;
        private System.Windows.Forms.Button btnConstruirAtrix;
        private System.Windows.Forms.Button btnConstruirNokia;
    }
}
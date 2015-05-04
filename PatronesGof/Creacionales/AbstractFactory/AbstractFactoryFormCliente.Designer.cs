namespace DesignPatterns.Creacionales.AbstractFactory
{
    partial class AbstractFactoryFormCliente
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
            this.btnTocarPiano = new System.Windows.Forms.Button();
            this.btnTocarGuitarra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTocarPiano
            // 
            this.btnTocarPiano.Location = new System.Drawing.Point(62, 26);
            this.btnTocarPiano.Name = "btnTocarPiano";
            this.btnTocarPiano.Size = new System.Drawing.Size(171, 28);
            this.btnTocarPiano.TabIndex = 0;
            this.btnTocarPiano.Text = "Tocar Piano";
            this.btnTocarPiano.UseVisualStyleBackColor = true;
            this.btnTocarPiano.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTocarGuitarra
            // 
            this.btnTocarGuitarra.Location = new System.Drawing.Point(62, 71);
            this.btnTocarGuitarra.Name = "btnTocarGuitarra";
            this.btnTocarGuitarra.Size = new System.Drawing.Size(171, 30);
            this.btnTocarGuitarra.TabIndex = 1;
            this.btnTocarGuitarra.Text = "Tocar Guitarra";
            this.btnTocarGuitarra.UseVisualStyleBackColor = true;
            this.btnTocarGuitarra.Click += new System.EventHandler(this.button2_Click);
            // 
            // AbstractFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.btnTocarGuitarra);
            this.Controls.Add(this.btnTocarPiano);
            this.Name = "AbstractFactoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTocarPiano;
        private System.Windows.Forms.Button btnTocarGuitarra;
    }
}
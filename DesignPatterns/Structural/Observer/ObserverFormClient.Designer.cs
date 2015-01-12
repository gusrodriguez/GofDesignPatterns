namespace DesignPatterns.Structural.Observer
{
    partial class ObserverFormClient
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
            this.lblTotal1Titulo = new System.Windows.Forms.Label();
            this.lblTotal2Titulo = new System.Windows.Forms.Label();
            this.lblTotal3Titulo = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal3 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal1Titulo
            // 
            this.lblTotal1Titulo.AutoSize = true;
            this.lblTotal1Titulo.Location = new System.Drawing.Point(41, 46);
            this.lblTotal1Titulo.Name = "lblTotal1Titulo";
            this.lblTotal1Titulo.Size = new System.Drawing.Size(43, 13);
            this.lblTotal1Titulo.TabIndex = 0;
            this.lblTotal1Titulo.Text = "Total 1:";
            // 
            // lblTotal2Titulo
            // 
            this.lblTotal2Titulo.AutoSize = true;
            this.lblTotal2Titulo.Location = new System.Drawing.Point(159, 46);
            this.lblTotal2Titulo.Name = "lblTotal2Titulo";
            this.lblTotal2Titulo.Size = new System.Drawing.Size(43, 13);
            this.lblTotal2Titulo.TabIndex = 1;
            this.lblTotal2Titulo.Text = "Total 2:";
            // 
            // lblTotal3Titulo
            // 
            this.lblTotal3Titulo.AutoSize = true;
            this.lblTotal3Titulo.Location = new System.Drawing.Point(267, 46);
            this.lblTotal3Titulo.Name = "lblTotal3Titulo";
            this.lblTotal3Titulo.Size = new System.Drawing.Size(43, 13);
            this.lblTotal3Titulo.TabIndex = 2;
            this.lblTotal3Titulo.Text = "Total 3:";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(15, 21);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(81, 20);
            this.txtValor1.TabIndex = 3;
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(206, 19);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtValor2);
            this.panel1.Controls.Add(this.txtValor1);
            this.panel1.Controls.Add(this.btnSumar);
            this.panel1.Location = new System.Drawing.Point(28, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 62);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt2);
            this.panel2.Controls.Add(this.txt1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 62);
            this.panel2.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(133, 22);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(108, 20);
            this.txt2.TabIndex = 5;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(15, 21);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(108, 20);
            this.txt1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(111, 20);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(81, 20);
            this.txtValor2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calculadora";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTotal3);
            this.panel3.Controls.Add(this.lblTotal2);
            this.panel3.Controls.Add(this.lblTotal1);
            this.panel3.Location = new System.Drawing.Point(28, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 40);
            this.panel3.TabIndex = 8;
            // 
            // lblTotal3
            // 
            this.lblTotal3.AutoSize = true;
            this.lblTotal3.Location = new System.Drawing.Point(288, 21);
            this.lblTotal3.Name = "lblTotal3";
            this.lblTotal3.Size = new System.Drawing.Size(0, 13);
            this.lblTotal3.TabIndex = 2;
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(180, 21);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(0, 13);
            this.lblTotal2.TabIndex = 1;
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Location = new System.Drawing.Point(63, 21);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(0, 13);
            this.lblTotal1.TabIndex = 0;
            // 
            // ObserverFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal3Titulo);
            this.Controls.Add(this.lblTotal2Titulo);
            this.Controls.Add(this.lblTotal1Titulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ObserverFormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObserverFormClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal1Titulo;
        private System.Windows.Forms.Label lblTotal2Titulo;
        private System.Windows.Forms.Label lblTotal3Titulo;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal3;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label lblTotal1;
    }
}
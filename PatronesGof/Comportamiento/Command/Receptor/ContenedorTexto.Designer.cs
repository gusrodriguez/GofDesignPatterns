namespace DesignPatterns.Comportamiento.Command.Receptor
{
    partial class ContenedorTexto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox = new System.Windows.Forms.TextBox();
            this.lstComandosEjecutados = new System.Windows.Forms.ListView();
            this.lblComandoEjecutado = new System.Windows.Forms.Label();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.CausesValidation = false;
            this.textbox.Location = new System.Drawing.Point(1, 16);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(360, 120);
            this.textbox.TabIndex = 1;
            // 
            // lstComandosEjecutados
            // 
            this.lstComandosEjecutados.BackColor = System.Drawing.SystemColors.Control;
            this.lstComandosEjecutados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstComandosEjecutados.LabelWrap = false;
            this.lstComandosEjecutados.Location = new System.Drawing.Point(3, 191);
            this.lstComandosEjecutados.Name = "lstComandosEjecutados";
            this.lstComandosEjecutados.Size = new System.Drawing.Size(354, 97);
            this.lstComandosEjecutados.TabIndex = 2;
            this.lstComandosEjecutados.UseCompatibleStateImageBehavior = false;
            // 
            // lblComandoEjecutado
            // 
            this.lblComandoEjecutado.AutoSize = true;
            this.lblComandoEjecutado.Location = new System.Drawing.Point(3, 175);
            this.lblComandoEjecutado.Name = "lblComandoEjecutado";
            this.lblComandoEjecutado.Size = new System.Drawing.Size(113, 13);
            this.lblComandoEjecutado.TabIndex = 3;
            this.lblComandoEjecutado.Text = "Comandos Ejecutados";
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(3, 294);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(353, 23);
            this.btnDeshacer.TabIndex = 4;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Texto";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(0, 139);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 6;
            // 
            // ContenedorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.lblComandoEjecutado);
            this.Controls.Add(this.lstComandosEjecutados);
            this.Controls.Add(this.textbox);
            this.Name = "ContenedorTexto";
            this.Size = new System.Drawing.Size(361, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.ListView lstComandosEjecutados;
        private System.Windows.Forms.Label lblComandoEjecutado;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;

    }
}

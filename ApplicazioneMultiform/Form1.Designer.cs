namespace ApplicazioneMultiform
{
    partial class FormAvvio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDatoDaTrasmettere = new System.Windows.Forms.TextBox();
            this.btnChiamaForm2 = new System.Windows.Forms.Button();
            this.txtSecondoParametro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDatoDaTrasmettere
            // 
            this.txtDatoDaTrasmettere.Location = new System.Drawing.Point(154, 49);
            this.txtDatoDaTrasmettere.Name = "txtDatoDaTrasmettere";
            this.txtDatoDaTrasmettere.Size = new System.Drawing.Size(125, 27);
            this.txtDatoDaTrasmettere.TabIndex = 0;
            // 
            // btnChiamaForm2
            // 
            this.btnChiamaForm2.Location = new System.Drawing.Point(154, 117);
            this.btnChiamaForm2.Name = "btnChiamaForm2";
            this.btnChiamaForm2.Size = new System.Drawing.Size(125, 46);
            this.btnChiamaForm2.TabIndex = 1;
            this.btnChiamaForm2.Text = "Apri Form Dati";
            this.btnChiamaForm2.UseVisualStyleBackColor = true;
            this.btnChiamaForm2.Click += new System.EventHandler(this.btnChiamaForm2_Click);
            // 
            // txtSecondoParametro
            // 
            this.txtSecondoParametro.Location = new System.Drawing.Point(379, 48);
            this.txtSecondoParametro.Name = "txtSecondoParametro";
            this.txtSecondoParametro.Size = new System.Drawing.Size(125, 27);
            this.txtSecondoParametro.TabIndex = 2;
            // 
            // FormAvvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSecondoParametro);
            this.Controls.Add(this.btnChiamaForm2);
            this.Controls.Add(this.txtDatoDaTrasmettere);
            this.Name = "FormAvvio";
            this.Text = "Form Principale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatoDaTrasmettere;
        private System.Windows.Forms.Button btnChiamaForm2;
        private System.Windows.Forms.TextBox txtSecondoParametro;
    }
}

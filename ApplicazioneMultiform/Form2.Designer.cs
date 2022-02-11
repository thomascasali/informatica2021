namespace ApplicazioneMultiform
{
    partial class FormDati
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnChiudi = new System.Windows.Forms.Button();
            this.txtSecondoParametro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisplay.Location = new System.Drawing.Point(80, 39);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(351, 28);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "testo proveniente dalla form principale";
            // 
            // btnChiudi
            // 
            this.btnChiudi.Location = new System.Drawing.Point(80, 116);
            this.btnChiudi.Name = "btnChiudi";
            this.btnChiudi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChiudi.Size = new System.Drawing.Size(140, 50);
            this.btnChiudi.TabIndex = 1;
            this.btnChiudi.Text = "Chiudi";
            this.btnChiudi.UseVisualStyleBackColor = true;
            this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
            // 
            // txtSecondoParametro
            // 
            this.txtSecondoParametro.BackColor = System.Drawing.Color.YellowGreen;
            this.txtSecondoParametro.Location = new System.Drawing.Point(543, 43);
            this.txtSecondoParametro.Name = "txtSecondoParametro";
            this.txtSecondoParametro.Size = new System.Drawing.Size(125, 27);
            this.txtSecondoParametro.TabIndex = 2;
            // 
            // FormDati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSecondoParametro);
            this.Controls.Add(this.btnChiudi);
            this.Controls.Add(this.lblDisplay);
            this.Name = "FormDati";
            this.Text = "Seconda Finestra";
            this.Load += new System.EventHandler(this.FormDati_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnChiudi;
        private System.Windows.Forms.TextBox txtSecondoParametro;
    }
}

namespace AS2122_4E_INF_Prof_PiuForm
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnInserimentoDati = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.lblCitta = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblGradimento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 27);
            this.txtNome.TabIndex = 1;
            // 
            // btnInserimentoDati
            // 
            this.btnInserimentoDati.Location = new System.Drawing.Point(231, 258);
            this.btnInserimentoDati.Name = "btnInserimentoDati";
            this.btnInserimentoDati.Size = new System.Drawing.Size(149, 56);
            this.btnInserimentoDati.TabIndex = 2;
            this.btnInserimentoDati.Text = "Inserimento dati";
            this.btnInserimentoDati.UseVisualStyleBackColor = true;
            this.btnInserimentoDati.Click += new System.EventHandler(this.btnInserimentoDati_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Indirizzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Città";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefono";
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.ForeColor = System.Drawing.Color.Red;
            this.lblIndirizzo.Location = new System.Drawing.Point(163, 93);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(18, 20);
            this.lblIndirizzo.TabIndex = 0;
            this.lblIndirizzo.Text = "...";
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.ForeColor = System.Drawing.Color.Red;
            this.lblCitta.Location = new System.Drawing.Point(163, 132);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(18, 20);
            this.lblCitta.TabIndex = 0;
            this.lblCitta.Text = "...";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.Red;
            this.lblTelefono.Location = new System.Drawing.Point(163, 169);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(18, 20);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "...";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(554, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(46, 29);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblGradimento
            // 
            this.lblGradimento.AutoSize = true;
            this.lblGradimento.ForeColor = System.Drawing.Color.Red;
            this.lblGradimento.Location = new System.Drawing.Point(135, 236);
            this.lblGradimento.Name = "lblGradimento";
            this.lblGradimento.Size = new System.Drawing.Size(18, 20);
            this.lblGradimento.TabIndex = 0;
            this.lblGradimento.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gradimento";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 335);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnInserimentoDati);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGradimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCitta);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Prof; 4E Lab 2.2; 26/01/2022; Esempio di gestione di più form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnInserimentoDati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblGradimento;
        private System.Windows.Forms.Label label6;
    }
}


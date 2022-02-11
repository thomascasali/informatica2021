using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ApplicazioneMultiform
{
    public partial class FormDati : Form
    {
        public string ParametroDaRestituire { get; set; }
        public FormDati(TextBox txtOrigine, string strSecondoParametro)
        {
            InitializeComponent();
            lblDisplay.Text = txtOrigine.Text;
            txtSecondoParametro.Text = strSecondoParametro;
        }

        private void FormDati_Load(object sender, EventArgs e)
        {

        }

        private void btnChiudi_Click(object sender, EventArgs e)
        {
            ParametroDaRestituire = txtSecondoParametro.Text;
            Close();
        }
    }
}

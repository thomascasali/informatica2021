using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicazioneMultiform
{
    public partial class FormAvvio : Form
    {
        public FormAvvio()
        {
            InitializeComponent();
        }

        private void btnChiamaForm2_Click(object sender, EventArgs e)
        {
            FormDati frmDati = new FormDati(txtDatoDaTrasmettere, txtSecondoParametro.Text); //istanzio (creo in memoria) una copia di FormDati
            frmDati.ShowDialog();
            txtSecondoParametro.Text= frmDati.ParametroDaRestituire;
        }
    }
}

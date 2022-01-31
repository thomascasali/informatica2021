using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_Prof_PiuForm
{
    public partial class frmDati : Form
    {

        string nome;

        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public string Telefono { get; set; }

        public frmDati(string nome)
        {
            this.nome = nome;

            InitializeComponent();
        }

        /// <summary>
        /// Visualizza i poarametri "passati" quando sei sicuro che il
        /// form ha concluso la sua fase di costruzione (evento Load())
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDati_Load(object sender, EventArgs e)
        {
            lblNome.Text = nome;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Indirizzo = txtIndirizzo.Text;
            Citta = txtCitta.Text;
            Telefono = txtTelefono.Text;

            // chiudi il form
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Indirizzo = "";
            Citta = "";
            Telefono = "";

            // chiudi il form
            Close();
        }
    }
}

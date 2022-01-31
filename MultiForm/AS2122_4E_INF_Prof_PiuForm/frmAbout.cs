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
    public partial class frmAbout : Form
    {
        string nome;

        public string Piacevolezza { get; set;}

        public frmAbout(string nome)
        {
            this.nome = nome;

            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Piacevolezza = cmbPiace.Text;

            // chiudi il form
            Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            if (nome=="")
                lblNome.Text = "Nome non impostato...";
            else
                lblNome.Text = nome;
        }
    }
}

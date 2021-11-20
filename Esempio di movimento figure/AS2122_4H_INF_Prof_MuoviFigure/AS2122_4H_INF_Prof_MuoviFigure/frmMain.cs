using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_MuoviFigure
{
    public partial class frmMain : Form
    {
        Figura f;

        int TOP_STEP = 10;
        int LEFT_STEP = 10;

        System.Drawing.Color colorFigura = System.Drawing.Color.Red;
        System.Drawing.Color colorEmpty = System.Drawing.Color.White;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            DrawFigura(pnlCanvas, colorEmpty, f);
            f.Top -= TOP_STEP;
            DrawFigura(pnlCanvas, colorFigura, f);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            DrawFigura(pnlCanvas, colorEmpty, f);
            f.Top += TOP_STEP;
            DrawFigura(pnlCanvas, colorFigura, f);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DrawFigura(pnlCanvas, colorEmpty, f);
            f.Left += LEFT_STEP;
            DrawFigura(pnlCanvas, colorFigura, f);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DrawFigura(pnlCanvas, colorEmpty, f);
            f.Left -= LEFT_STEP;
            DrawFigura(pnlCanvas, colorFigura, f);
        }

        void DrawFigura(Panel pnl, System.Drawing.Color color, Figura figura)
        {

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(color);
            System.Drawing.Graphics formGraphics;
            formGraphics = pnl.CreateGraphics();

            if (figura is Rettangolo)
            {
                Rettangolo f = (Rettangolo)figura;

                formGraphics.FillRectangle(myBrush, new Rectangle(f.Left, f.Top, (int)f.Base * 10, (int)f.Altezza * 10));
            }
            else if (figura is Cerchio)
            {
                Cerchio f = (Cerchio)figura;

                formGraphics.FillEllipse(myBrush, new Rectangle(f.Left, f.Top, (int)f.Raggio * 10, (int)f.Raggio * 10));
            }
            else if (figura is Quadrato)
            {
                Quadrato f = (Quadrato)figura;

                formGraphics.FillRectangle(myBrush, new Rectangle(f.Left, f.Top, (int)f.Lato * 10, (int)f.Lato * 10));
            }
            myBrush.Dispose();
            formGraphics.Dispose();
        }



        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            switch (cmbFigura.Text.ToUpper())
            {
                case "RETTANGOLO":
                    f = new Rettangolo(2, 5);
                    break;

                case "CERCHIO":
                    f = new Cerchio(15);
                    break;

                case "QUADRATO":
                    f = new Quadrato(8);
                    break;
            }
        }
    }
}

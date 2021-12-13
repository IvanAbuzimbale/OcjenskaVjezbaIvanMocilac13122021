using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcjenskaVjezbaIvanMocilac13122021
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btn_UnosKorisnika_Click(object sender, EventArgs e)
        {
            FrmUnosKorisnika frmUnosKorisnika = new FrmUnosKorisnika();
            frmUnosKorisnika.Show();
        }

        private void btnUnosPosudbe_Click(object sender, EventArgs e)
        {
            FrmUnosPosudbe frmUnosPosudbe = new FrmUnosPosudbe();
            frmUnosPosudbe.Show();
        }

        private void btnUnosKnjige_Click(object sender, EventArgs e)
        {
            FrmUnosKnjige frmUnosKnjige = new FrmUnosKnjige();
            frmUnosKnjige.Show();
        }
    }
}

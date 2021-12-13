using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OcjenskaVjezbaIvanMocilac13122021
{
    public partial class FrmUnosKorisnika : Form
    {

        public FrmUnosKorisnika()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
        new XDocument(
        new XElement("Korisnik",
        new XElement(textBoxIme.Text, "int")
            )
        )
        .Save("Korisnik.xml");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkone_Logiciel_Evenementiel
{
    public partial class FormEvenements : Form
    {
        public FormEvenements()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDetailEvenement formSelectedEvenement = new FormDetailEvenement();
            formSelectedEvenement.Show();
            this.Hide();
        }
    }
}

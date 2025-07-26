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
    public partial class FromOrga : Form
    {
        public FromOrga()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        //Ouvre une vue vers la liste des évènements
        private void button1_Click(object sender, EventArgs e)
        {
            FormEvenements formListEvenement = new FormEvenements();
            formListEvenement.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateEvent home = new FormCreateEvent();
            home.Show();
        }
    }
}

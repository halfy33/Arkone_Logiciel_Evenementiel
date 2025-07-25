using Arkone_Logiciel_Evenementiel.Models;
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
    public partial class FormDetailEvenement : Form
    {
        private Evenement selectedEvenement;

        public FormDetailEvenement(Evenement evenement)
        {
            InitializeComponent();
            selectedEvenement = evenement;

            label_evenementDescription.Text = selectedEvenement.ToString();
            label_nomEvenement.Text = selectedEvenement.NomEvenement;
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            FormEvenements formListEvenement = new FormEvenements();
            formListEvenement.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser(selectedEvenement.IdEvenement);
            formCreateUser.Show();
            this.Hide();
        }
    }
}

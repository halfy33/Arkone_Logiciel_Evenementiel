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
    public partial class FormEvenements : Form
    {
        public FormEvenements()
        {
            InitializeComponent();
            list_evenement();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDetailEvenement formSelectedEvenement = new FormDetailEvenement();
            formSelectedEvenement.Show();
            this.Hide();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromOrga home = new FromOrga();
            home.Show();
        }

        private void list_evenement()
        {
            using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
            {
                var evenements = db.Evenements
                    .OrderBy(e => e.DateEvenement)
                    .ToList();

                listbox_evenement.Items.Clear(); // Vide la liste avant ajout

                foreach (var evt in evenements)
                {
                    listbox_evenement.Items.Add(evt); // Appelle automatiquement evt.ToString()
                }
            }
        }
    }
}

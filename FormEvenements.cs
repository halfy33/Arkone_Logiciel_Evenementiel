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
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            list_evenement();
        }

        //Ouvre le détail de l'évènement lorsqu'on clique dessus
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_evenement.SelectedItem is Evenement evt)
            {
                FormDetailEvenement formSelectedEvenement = new FormDetailEvenement(evt);
                formSelectedEvenement.Show();
                this.Hide();
            }
        }
        //retour page précédente -> Menu Orga
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromOrga menuOrga = new FromOrga();
            menuOrga.Show();
        }

        //liste les éléments avec filtrage dynamique (en fonction du nom ou du lieu)
        private void list_evenement(string? filtreRecherche=null)
        {
            using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
            {
                // Liste les évènement
                var evenementsQuery = db.Evenements.AsQueryable();

                // Appliquer le filtre si fourni (nom OU lieu contient la valeur)
                if (!string.IsNullOrWhiteSpace(filtreRecherche))
                {
                    evenementsQuery = evenementsQuery.Where(e =>
                        e.NomEvenement.Contains(filtreRecherche) ||
                        e.Lieu.Contains(filtreRecherche));
                }

                // Tri par date croissante
                evenementsQuery = evenementsQuery.OrderBy(e => e.DateEvenement);

                // Exécution
                var evenements = evenementsQuery.ToList();

                listbox_evenement.Items.Clear(); // Vide la liste avant ajout

                foreach (var evt in evenementsQuery)
                {
                    listbox_evenement.Items.Add(evt); // Appelle automatiquement evt.ToString()
                }
            }
        }

        //actualise la liste à chaque changement de champ
        private void textbox_recherchEvenement_TextChanged(object sender, EventArgs e)
        {
            list_evenement(textbox_recherchEvenement.Text);
        }
    }
}

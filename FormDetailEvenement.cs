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
using Microsoft.EntityFrameworkCore;

namespace Arkone_Logiciel_Evenementiel
{
    public partial class FormDetailEvenement : Form
    {
        private Evenement selectedEvenement;

        public FormDetailEvenement(Evenement evenement)
        {
            InitializeComponent();
            selectedEvenement = evenement;

            // Affiche le nom et la description de l'évènement
            label_evenementDescription.Text = selectedEvenement.ToString();
            label_nomEvenement.Text = selectedEvenement.NomEvenement;

            // charge la liste des invités à l'évènement
            load_listeInvites(evenement);
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            FormEvenements formListEvenement = new FormEvenements();
            formListEvenement.Show();
            this.Hide();
        }

        private void load_listeInvites(Evenement evenement)
        {
            int idEvenement = evenement.IdEvenement;

            using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
            {
                var invites = db.Invitations
                    .Where(i => i.IdEvenement == idEvenement)
                    .Include(i => i.IdInviteNavigation) // charge les données de l'invité (relation navigationnelle)
                    .Select(i => i.IdInviteNavigation)
                    .ToList();

                listbox_invites.Items.Clear();

                foreach (var invite in invites)
                {
                    listbox_invites.Items.Add(invite); // ou invite.NomPrenom si tu préfères du texte simple
                }
            }
        }
    }
}

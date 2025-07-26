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
            load_notInvites(evenement);
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            FormEvenements formListEvenement = new FormEvenements();
            formListEvenement.Show();
            this.Hide();
        }

        private void load_listeInvites(Evenement evenement, string? filtreRecherche = null)
        {
            int idEvenement = evenement.IdEvenement;

            using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
            {
                // Invités liés à l'événement
                var invitesQuery = db.Invites
                .Where(invite => db.Invitations
                .Where(i => i.IdEvenement == idEvenement)
                .Select(i => i.IdInvite)
                .Contains(invite.IdInvite));

                if (!string.IsNullOrWhiteSpace(filtreRecherche))
                {
                    invitesQuery = invitesQuery.Where(i =>
                    i.Nom.Contains(filtreRecherche) ||
                    i.Prenom.Contains(filtreRecherche));
                }
                ;

                invitesQuery.ToList();

                listbox_invites.Items.Clear();

                foreach (var invite in invitesQuery)
                {
                    listbox_invites.Items.Add(invite);
                }
            }
        }

        public void load_notInvites(Evenement evenement, string? filtreRecherche = null)
        {
            var idEvenement = evenement.IdEvenement;

            using (var db = new ArkoneEnzoYanisContext())
            {
                // Invités non liés à l'événement
                var invitesQuery = db.Invites
                    .Where(invite => !db.Invitations
                        .Where(i => i.IdEvenement == idEvenement)
                        .Select(i => i.IdInvite)
                        .Contains(invite.IdInvite));

                // Appliquer le filtre si fourni (nom OU prénom contient la valeur)
                if (!string.IsNullOrWhiteSpace(filtreRecherche))
                {
                    invitesQuery = invitesQuery.Where(i =>
                        i.Nom.Contains(filtreRecherche) ||
                        i.Prenom.Contains(filtreRecherche));
                }

                listbox_notInvite.Items.Clear();

                foreach (var invite in invitesQuery)
                {
                    listbox_notInvite.Items.Add(invite);
                }
            }
        }

        private void btn_ajoutInvite_Click(object sender, EventArgs e)
        {
            if (listbox_notInvite.SelectedItem is Invite inv)
            {
                Invite selectedInvite = inv;

                Invitation newInvitation = new Invitation();

                newInvitation.AjouterInvitation(selectedEvenement, selectedInvite);

                load_listeInvites(selectedEvenement);
                load_notInvites(selectedEvenement);
                label_evenementDescription.Text = selectedEvenement.ToString();

            }
        }

        private void texbox_rechercheInvite_TextChanged(object sender, EventArgs e)
        {
            load_notInvites(selectedEvenement, texbox_rechercheInvite.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser(selectedEvenement);
            formCreateUser.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load_listeInvites(selectedEvenement, textBox1.Text);
        }
    }
}

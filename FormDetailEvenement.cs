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
        //Création d'un variable globale pour garder en mémoire l'évènement en cours
        private Evenement selectedEvenement;

        public FormDetailEvenement(Evenement evenement)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            selectedEvenement = evenement;

            // Affiche le nom et la description de l'évènement
            label_evenementDescription.Text = selectedEvenement.ToString();
            label_nomEvenement.Text = selectedEvenement.NomEvenement;

            // charge la liste des invités à l'évènement
            load_listeInvites(evenement);
            load_notInvites(evenement);
        }

        //Retour page précédente
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            FormEvenements formListEvenement = new FormEvenements();
            formListEvenement.Show();
            this.Hide();
        }

        //Charge la liste des personnes invités à l'évènement
        private void load_listeInvites(Evenement evenement, string? filtreRecherche = null)
        {
            int idEvenement = evenement.IdEvenement;

            using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
            {
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

        //Charge la liste des personnes par encore invités à l'évènement
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

                invitesQuery.ToList();

                listbox_notInvite.Items.Clear();

                foreach (var invite in invitesQuery)
                {
                    listbox_notInvite.Items.Add(invite);
                }
            }
        }

        //Création d'un invitations
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

        //recharge les listes à chaque changement de valeur dans les filtres
        private void texbox_rechercheInvite_TextChanged(object sender, EventArgs e)
        {
            load_notInvites(selectedEvenement, texbox_rechercheInvite.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load_listeInvites(selectedEvenement, textBox1.Text);
        }

        //Ouvre le formulaire de création d'utilisateur
        private void button2_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser(selectedEvenement);
            formCreateUser.Show();
            this.Hide();
        }

        
    }
}

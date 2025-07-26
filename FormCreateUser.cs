using Arkone_Logiciel_Evenementiel.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormCreateUser : Form
    {
        //Création d'un variable globale pour garder en mémoire l'évènement en cours
        private Evenement evenementActuel;

        public FormCreateUser(Evenement evenement)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            evenementActuel = evenement;
        }

        //Ajout d'un invité dans la base et génération de l'invitation pour l'évènement
        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            // Vérification de base
            if (string.IsNullOrWhiteSpace(txt_NameUser.Text) ||
                string.IsNullOrWhiteSpace(txt_SurnameUser.Text) ||
                string.IsNullOrWhiteSpace(txt_MailUser.Text) ||
                string.IsNullOrWhiteSpace(txt_PhoneUser.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
                return;
            }

            try
            {
                using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
                {
                    Invite nouvelInvite = new Invite
                    {
                        Nom = txt_NameUser.Text.Trim(),
                        Prenom = txt_SurnameUser.Text.Trim(),
                        Mail = txt_MailUser.Text.Trim(),
                        Telephone = txt_PhoneUser.Text.Trim()
                    };

                    db.Invites.Add(nouvelInvite);
                    db.SaveChanges();


                    db.Database.ExecuteSqlRaw("EXEC ps_GenererInvitation @p0, @p1", nouvelInvite.IdInvite, evenementActuel.IdEvenement);
                }



                MessageBox.Show("Invité créé avec succès !");

                // Nettoyer les champs
                txt_NameUser.Clear();
                txt_SurnameUser.Clear();
                txt_MailUser.Clear();
                txt_PhoneUser.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création : " + ex.Message);
            }
        }

        //Retour page précédente
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            FormDetailEvenement previousForm = new FormDetailEvenement(evenementActuel);
            previousForm.Show();
            this.Hide();
        }
    }
}


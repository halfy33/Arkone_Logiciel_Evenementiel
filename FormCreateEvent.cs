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
    public partial class FormCreateEvent : Form
    {
        public FormCreateEvent()
        {
            InitializeComponent();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromOrga home = new FromOrga();
            home.Show();
        }

        private void btn_CreateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification de base
                if (string.IsNullOrWhiteSpace(txt_nameEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_LieuEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_LatitudeEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_LongitudeEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_DateEvent.Text))
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                // Parsing de la date
                if (!DateTime.TryParse(txt_DateEvent.Text, out DateTime dateEvenement))
                {
                    MessageBox.Show("Date invalide.");
                    return;
                }

                // Création de l'objet événement
                Evenement newEvent = new Evenement
                {
                    NomEvenement = txt_nameEvent.Text.Trim(),
                    Lieu = txt_LieuEvent.Text,
                    Latitude = txt_LatitudeEvent.Text.Trim(),
                    Longitude = txt_LongitudeEvent.Text.Trim(),
                    DateEvenement = dateEvenement
                };

                // Sauvegarde en base
                using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
                {
                    db.Evenements.Add(newEvent);
                    db.SaveChanges();
                }

                MessageBox.Show("Événement créé avec succès !");
                // Vider les champs aprè création
                txt_nameEvent.Text = "";
                txt_LieuEvent.Text = "";
                txt_LatitudeEvent.Text = "";
                txt_LongitudeEvent.Text = "";
                txt_DateEvent.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}

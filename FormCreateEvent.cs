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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += btn_Retour_Click;
            InitializeComponent();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromOrga home = new FromOrga();
            home.Show();
        }

        //Création d'un nouvel évènement en base de données
        private void btn_CreateEvent_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification de base
                if (string.IsNullOrWhiteSpace(txt_nameEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_LieuEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_LatitudeEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_LongitudeEvent.Text) ||
                    string.IsNullOrWhiteSpace(txt_HeureEvent.Text))

                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                    return;
                }

                DateTime date = date_Picker1.Value.Date;

                string heureStr = txt_HeureEvent.Text.Trim();


                // Parsing de la date
                if (!DateTime.TryParseExact(heureStr, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime heure))
                {
                    MessageBox.Show("Heure invalide. Format attendu : HH:mm (ex: 14:30)");
                    return;
                }

                DateTime dateTimeComplete = date.AddHours(heure.Hour).AddMinutes(heure.Minute);

                // Création de l'objet événement
                Evenement newEvent = new Evenement
                {
                    NomEvenement = txt_nameEvent.Text.Trim(),
                    Lieu = txt_LieuEvent.Text,
                    Latitude = txt_LatitudeEvent.Text.Trim(),
                    Longitude = txt_LongitudeEvent.Text.Trim(),
                    DateEvenement = dateTimeComplete,
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
                txt_HeureEvent.Text = "";
            }
            catch (Exception ex)
            {
                if (ex.InnerException?.Message.Contains("CK_Evenement_Latitude") == true)
                {
                    MessageBox.Show("La latitude doit être un nombre entre 41.3030 et 51.1242 (coordonnées valides en France).");
                }
                else if (ex.InnerException?.Message.Contains("CK_Evenement_Longitude") == true)
                {
                    MessageBox.Show("La longitude doit être un nombre entre -5.1422 et 9.5616 (coordonnées valides en France).");
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement : " + ex.InnerException?.Message);
                }
            }
        }
    }
}


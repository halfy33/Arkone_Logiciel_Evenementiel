using Arkone_Logiciel_Evenementiel.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Arkone_Logiciel_Evenementiel
{
    internal class Invitation
    {
        //Appel d'un procédure stocké pour générer un invitation qui asssocie un client et un évènement
        public void AjouterInvitation(Evenement selsectedEvenemet, Invite SelectedInvite)
        {
            if (SelectedInvite != null)
            {
                int idInvite = SelectedInvite.IdInvite;
                int idEvenement = selsectedEvenemet.IdEvenement;

                try
                {
                    using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
                    {
                        var connection = db.Database.GetDbConnection();
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "ps_GenererInvitation";
                            command.CommandType = CommandType.StoredProcedure;

                            var evenement = new SqlParameter("@idEvenement", idEvenement);
                            var invite = new SqlParameter("@idInvite", idInvite);
                            command.Parameters.Add(evenement);
                            command.Parameters.Add(invite);

                            command.ExecuteNonQuery();
                        }

                        var invitationGeneree = db.Invitations
                            .FirstOrDefault(i => i.IdEvenement == idEvenement && i.IdInvite == idInvite);

                        if (invitationGeneree != null && !string.IsNullOrEmpty(invitationGeneree.Code))
                        {
                            this.EnvoyerEmailBrevo(SelectedInvite, selsectedEvenemet, invitationGeneree.Code);
                        }
                        else
                        {
                            MessageBox.Show("Le code d'invitation n'a pas pu être récupéré.");
                        }

                        MessageBox.Show("Invité avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"[Erreur : {ex.Message}]");
                }
            }
        }

        //Valide la présence via une procédure stockée en passant la statut de présence à 1 dans l'invitation
        public void CheckInInvitation(string? codeInvitation)
        {
            if (!string.IsNullOrWhiteSpace(codeInvitation) || codeInvitation.Length == 6)
            {
                try
                {
                    using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
                    {
                        var connection = db.Database.GetDbConnection();
                        connection.Open();

                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = "sp_ValiderPresence";
                            command.CommandType = CommandType.StoredProcedure;

                            var code = new SqlParameter("@code", codeInvitation);
                            command.Parameters.Add(code);

                            var result = command.ExecuteScalar(); // lit le champ "description"

                            MessageBox.Show("Invitation Valide !");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"[Erreur : {ex.Message}]");
                }
            }
            else
            {
                MessageBox.Show("Veuillez Saisir un code valide");
            }
        }



        public void EnvoyerEmailBrevo(Invite invite, Evenement evenement, string code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("bertobambi@gmail.com", "Arkone Team");
                mail.To.Add(invite.Mail);
                mail.Subject = "Invitation à l'événement " + evenement.NomEvenement;

                mail.Body = $@"
                    Bonjour {invite.Prenom} {invite.Nom},

                    Vous êtes invité à l'événement : {evenement.NomEvenement}.

                    Voici votre code d'accès : {code}

                    À très bientôt !
                    ";

                SmtpClient smtp = new SmtpClient("smtp-relay.brevo.com", 587);
                smtp.Credentials = new NetworkCredential("934039001@smtp-brevo.com", "Uq8hjDPcmndLTzfb");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoi du mail : " + ex.Message);
            }
        }
    }
}

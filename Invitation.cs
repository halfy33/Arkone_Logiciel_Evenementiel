using Arkone_Logiciel_Evenementiel.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

                            var result = command.ExecuteScalar();

                            MessageBox.Show("Invité aves succès !");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"[Erreur : {ex.Message}]") ;
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
    }
}

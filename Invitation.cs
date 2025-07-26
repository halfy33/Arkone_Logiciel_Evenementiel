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

                            var result = command.ExecuteScalar(); // lit le champ "description"

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
    }
}

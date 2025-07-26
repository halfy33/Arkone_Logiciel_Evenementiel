using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Arkone_Logiciel_Evenementiel.Models;

public partial class Evenement
{
    //Surcharge de la fonction pour appler un procédure stocké construisant une description (string) pour les évènements
    public override string ToString()
    {
        try
        {
            using (ArkoneEnzoYanisContext db = new ArkoneEnzoYanisContext())
            {
                var connection = db.Database.GetDbConnection();
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "sp_GetDescriptionEvenement";
                    command.CommandType = CommandType.StoredProcedure;

                    var param = new SqlParameter("@idEvenement", this.IdEvenement);
                    command.Parameters.Add(param);

                    var result = command.ExecuteScalar(); // lit le champ "description"

                    return result?.ToString() ?? base.ToString();
                }
            }
        }
        catch (Exception ex)
        {
            return $"[Erreur : {ex.Message}]";
        }
    }
}

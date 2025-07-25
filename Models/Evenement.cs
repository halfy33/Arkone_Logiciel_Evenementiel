using System;
using System.Collections.Generic;

namespace Arkone_Logiciel_Evenementiel.Models;

public partial class Evenement
{
    public int IdEvenement { get; set; }

    public string NomEvenement { get; set; } = null!;

    public string Lieu { get; set; } = null!;

    public DateTime DateEvenement { get; set; }

    public string Latitude { get; set; } = null!;

    public string Longitude { get; set; } = null!;

    public virtual ICollection<Invitation> Invitations { get; set; } = new List<Invitation>();

}

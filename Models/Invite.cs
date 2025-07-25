using System;
using System.Collections.Generic;

namespace Arkone_Logiciel_Evenementiel.Models;

public partial class Invite
{
    public int IdInvite { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string? Telephone { get; set; }

    public virtual ICollection<Invitation> Invitations { get; set; } = new List<Invitation>();
}

using System;
using System.Collections.Generic;

namespace Arkone_Logiciel_Evenementiel.Models;

public partial class Invitation
{
    public int IdInvitation { get; set; }

    public bool EstPresent { get; set; }

    public string? Code { get; set; }

    public int IdEvenement { get; set; }

    public int IdInvite { get; set; }

    public virtual Evenement IdEvenementNavigation { get; set; } = null!;

    public virtual Invite IdInviteNavigation { get; set; } = null!;
}

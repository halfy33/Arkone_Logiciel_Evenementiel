using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkone_Logiciel_Evenementiel.Models;

public partial class Invite
{
    //Surcharge de la fonction pour afficher les élément de l'objet
    public override string ToString()
    {
        return (this.Nom + " " + this.Prenom);
    }
}

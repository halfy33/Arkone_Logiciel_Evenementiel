using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkone_Logiciel_Evenementiel
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.FormClosing += BaseForm_FormClosing;
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ferme toute l'application
        }
    }
}

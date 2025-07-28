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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += FormHome_FormClosing;
            InitializeComponent();            
        }
        //Accès à la saisie de code d'inviation
        private void btn_ModuleAgent_Click(object sender, EventArgs e)
        {
            Form1 monForm = new Form1();
            monForm.Show();
            this.Hide();
        }
        //Accès au menu Organisation
        private void s_Click(object sender, EventArgs e)
        {
            FromOrga formOrga = new FromOrga();
            formOrga.Show();
            this.Hide();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ferme toute l'application
        }
    }
}

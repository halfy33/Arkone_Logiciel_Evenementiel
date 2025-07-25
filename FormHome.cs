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
            InitializeComponent();
            
        }

        private void btn_ModuleAgent_Click(object sender, EventArgs e)
        {
            Form1 monForm = new Form1();
            monForm.Show();
            this.Hide();
        }

        private void s_Click(object sender, EventArgs e)
        {
            FromOrga formOrga = new FromOrga();
            formOrga.Show();
            this.Hide();
        }
    }
}

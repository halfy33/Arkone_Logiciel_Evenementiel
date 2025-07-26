using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Arkone_Logiciel_Evenementiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_VerifCode.MaxLength = 6;

        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void txt_VerifCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // ignore le caractère
            }
        }

        private void btn_VerifCode_Click(object sender, EventArgs e)
        {
            string code = txt_VerifCode.Text;

            Invitation invitation = new Invitation();            
            invitation.CheckInInvitation(code);
        }
    }
}


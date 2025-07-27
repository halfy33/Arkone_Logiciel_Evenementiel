using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Arkone_Logiciel_Evenementiel
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            txt_VerifCode.MaxLength = 6;

        }

        //Retour page pr�c�dente -> Menu
        private void btn_Retour_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        //V�rifie les caract�res saisis dans le champ (Lettre et chiffres uniquement)
        private void txt_VerifCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // ignore le caract�re
            }
        }

        //V�rifier le code et valide la pr�sence de l'invit� => proc�dure stock�e en BDD
        private void btn_VerifCode_Click(object sender, EventArgs e)
        {
            string code = txt_VerifCode.Text;

            Invitation invitation = new Invitation();            
            invitation.CheckInInvitation(code);
        }
    }
}


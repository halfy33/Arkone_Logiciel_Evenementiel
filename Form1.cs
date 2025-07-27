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

        //Retour page précédente -> Menu
        private void btn_Retour_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        //Vérifie les caractères saisis dans le champ (Lettre et chiffres uniquement)
        private void txt_VerifCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // ignore le caractère
            }
        }

        //Vérifier le code et valide la présence de l'invité => procédure stockée en BDD
        private void btn_VerifCode_Click(object sender, EventArgs e)
        {
            string code = txt_VerifCode.Text;

            Invitation invitation = new Invitation();            
            invitation.CheckInInvitation(code);
        }
    }
}


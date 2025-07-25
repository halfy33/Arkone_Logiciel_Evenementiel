namespace Arkone_Logiciel_Evenementiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
       
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

    }
}


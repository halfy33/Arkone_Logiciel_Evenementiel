namespace Arkone_Logiciel_Evenementiel
{
    partial class FormDetailEvenement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_nomEvenement = new Label();
            listbox_invites = new ListBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            texbox_rechercheInvite = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_Retour = new Button();
            SuspendLayout();
            // 
            // label_nomEvenement
            // 
            label_nomEvenement.AutoSize = true;
            label_nomEvenement.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nomEvenement.Location = new Point(12, 1);
            label_nomEvenement.Name = "label_nomEvenement";
            label_nomEvenement.Size = new Size(296, 41);
            label_nomEvenement.TabIndex = 0;
            label_nomEvenement.Text = "Nom de l'évènement";
            // 
            // listbox_invites
            // 
            listbox_invites.FormattingEnabled = true;
            listbox_invites.Location = new Point(12, 174);
            listbox_invites.Name = "listbox_invites";
            listbox_invites.Size = new Size(326, 324);
            listbox_invites.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(609, 77);
            label1.Name = "label1";
            label1.Size = new Size(240, 31);
            label1.TabIndex = 2;
            label1.Text = "Envoyer une invitation";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(609, 174);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 264);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(609, 444);
            button1.Name = "button1";
            button1.Size = new Size(259, 29);
            button1.TabIndex = 4;
            button1.Text = "Ajouter à l'évènement";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(609, 479);
            button2.Name = "button2";
            button2.Size = new Size(259, 29);
            button2.TabIndex = 5;
            button2.Text = "Créer un nouvel invité";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 6;
            // 
            // texbox_rechercheInvite
            // 
            texbox_rechercheInvite.Location = new Point(609, 141);
            texbox_rechercheInvite.Name = "texbox_rechercheInvite";
            texbox_rechercheInvite.Size = new Size(259, 27);
            texbox_rechercheInvite.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(609, 118);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 8;
            label2.Text = "Recherche :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 9;
            label3.Text = "Recherche :";
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(12, 504);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(64, 29);
            btn_Retour.TabIndex = 10;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // FormDetailEvenement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 541);
            Controls.Add(btn_Retour);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(texbox_rechercheInvite);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(listbox_invites);
            Controls.Add(label_nomEvenement);
            Name = "FormDetailEvenement";
            Text = "FormDetailEvenement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nomEvenement;
        private ListBox listbox_invites;
        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox texbox_rechercheInvite;
        private Label label2;
        private Label label3;
        private Button btn_Retour;
    }
}
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
            listbox_notInvite = new ListBox();
            btn_ajoutInvite = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            texbox_rechercheInvite = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_Retour = new Button();
            label_evenementDescription = new Label();
            SuspendLayout();
            // 
            // label_nomEvenement
            // 
            label_nomEvenement.AutoSize = true;
            label_nomEvenement.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_nomEvenement.Location = new Point(10, 1);
            label_nomEvenement.Name = "label_nomEvenement";
            label_nomEvenement.Size = new Size(241, 32);
            label_nomEvenement.TabIndex = 0;
            label_nomEvenement.Text = "Nom de l'évènement";
            // 
            // listbox_invites
            // 
            listbox_invites.FormattingEnabled = true;
            listbox_invites.ItemHeight = 15;
            listbox_invites.Location = new Point(10, 130);
            listbox_invites.Margin = new Padding(3, 2, 3, 2);
            listbox_invites.Name = "listbox_invites";
            listbox_invites.Size = new Size(286, 244);
            listbox_invites.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(533, 55);
            label1.Name = "label1";
            label1.Size = new Size(200, 25);
            label1.TabIndex = 2;
            label1.Text = "Envoyer une invitation";
            // 
            // listbox_notInvite
            // 
            listbox_notInvite.FormattingEnabled = true;
            listbox_notInvite.ItemHeight = 15;
            listbox_notInvite.Location = new Point(533, 130);
            listbox_notInvite.Margin = new Padding(3, 2, 3, 2);
            listbox_notInvite.Name = "listbox_notInvite";
            listbox_notInvite.Size = new Size(227, 199);
            listbox_notInvite.TabIndex = 3;
            // 
            // btn_ajoutInvite
            // 
            btn_ajoutInvite.Location = new Point(533, 333);
            btn_ajoutInvite.Margin = new Padding(3, 2, 3, 2);
            btn_ajoutInvite.Name = "btn_ajoutInvite";
            btn_ajoutInvite.Size = new Size(227, 22);
            btn_ajoutInvite.TabIndex = 4;
            btn_ajoutInvite.Text = "Ajouter à l'évènement";
            btn_ajoutInvite.UseVisualStyleBackColor = true;
            btn_ajoutInvite.Click += btn_ajoutInvite_Click;
            // 
            // button2
            // 
            button2.Location = new Point(533, 359);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(227, 22);
            button2.TabIndex = 5;
            button2.Text = "Créer un nouvel invité";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 106);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // texbox_rechercheInvite
            // 
            texbox_rechercheInvite.Location = new Point(533, 106);
            texbox_rechercheInvite.Margin = new Padding(3, 2, 3, 2);
            texbox_rechercheInvite.Name = "texbox_rechercheInvite";
            texbox_rechercheInvite.Size = new Size(227, 23);
            texbox_rechercheInvite.TabIndex = 7;
            texbox_rechercheInvite.TextChanged += texbox_rechercheInvite_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(533, 88);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "Recherche :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 88);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Recherche :";
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(10, 378);
            btn_Retour.Margin = new Padding(3, 2, 3, 2);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(56, 22);
            btn_Retour.TabIndex = 10;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // label_evenementDescription
            // 
            label_evenementDescription.AutoSize = true;
            label_evenementDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_evenementDescription.Location = new Point(10, 32);
            label_evenementDescription.Name = "label_evenementDescription";
            label_evenementDescription.Size = new Size(241, 25);
            label_evenementDescription.TabIndex = 11;
            label_evenementDescription.Text = "Description de l'évènement";
            // 
            // FormDetailEvenement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 406);
            Controls.Add(label_evenementDescription);
            Controls.Add(btn_Retour);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(texbox_rechercheInvite);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(btn_ajoutInvite);
            Controls.Add(listbox_notInvite);
            Controls.Add(label1);
            Controls.Add(listbox_invites);
            Controls.Add(label_nomEvenement);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDetailEvenement";
            Text = "Arkone Details des événements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nomEvenement;
        private ListBox listbox_invites;
        private Label label1;
        private ListBox listbox_notInvite;
        private Button btn_ajoutInvite;
        private Button button2;
        private TextBox textBox1;
        private TextBox texbox_rechercheInvite;
        private Label label2;
        private Label label3;
        private Button btn_Retour;
        private Label label_evenementDescription;
    }
}
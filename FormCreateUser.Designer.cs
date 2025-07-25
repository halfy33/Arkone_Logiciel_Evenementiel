namespace Arkone_Logiciel_Evenementiel
{
    partial class FormCreateUser
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_NameUser = new TextBox();
            txt_SurnameUser = new TextBox();
            txt_MailUser = new TextBox();
            txt_PhoneUser = new TextBox();
            btn_CreateUser = new Button();
            btn_Retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 143);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 191);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Prénom : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 246);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Adresse Mail : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 295);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Téléphone : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(259, 46);
            label5.Name = "label5";
            label5.Size = new Size(303, 41);
            label5.TabIndex = 4;
            label5.Text = "Créer un invité";
            // 
            // txt_NameUser
            // 
            txt_NameUser.Location = new Point(349, 136);
            txt_NameUser.Name = "txt_NameUser";
            txt_NameUser.Size = new Size(125, 27);
            txt_NameUser.TabIndex = 5;
            // 
            // txt_SurnameUser
            // 
            txt_SurnameUser.Location = new Point(349, 188);
            txt_SurnameUser.Name = "txt_SurnameUser";
            txt_SurnameUser.Size = new Size(125, 27);
            txt_SurnameUser.TabIndex = 6;
            // 
            // txt_MailUser
            // 
            txt_MailUser.Location = new Point(349, 243);
            txt_MailUser.Name = "txt_MailUser";
            txt_MailUser.Size = new Size(125, 27);
            txt_MailUser.TabIndex = 7;
            // 
            // txt_PhoneUser
            // 
            txt_PhoneUser.Location = new Point(349, 295);
            txt_PhoneUser.Name = "txt_PhoneUser";
            txt_PhoneUser.Size = new Size(125, 27);
            txt_PhoneUser.TabIndex = 8;
            // 
            // btn_CreateUser
            // 
            btn_CreateUser.Location = new Point(349, 364);
            btn_CreateUser.Name = "btn_CreateUser";
            btn_CreateUser.Size = new Size(94, 29);
            btn_CreateUser.TabIndex = 9;
            btn_CreateUser.Text = "Créer";
            btn_CreateUser.UseVisualStyleBackColor = true;
            btn_CreateUser.Click += btn_CreateUser_Click;
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(8, 413);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(64, 29);
            btn_Retour.TabIndex = 11;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            // 
            // FormCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Retour);
            Controls.Add(btn_CreateUser);
            Controls.Add(txt_PhoneUser);
            Controls.Add(txt_MailUser);
            Controls.Add(txt_SurnameUser);
            Controls.Add(txt_NameUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreateUser";
            Text = "FormCreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_NameUser;
        private TextBox txt_SurnameUser;
        private TextBox txt_MailUser;
        private TextBox txt_PhoneUser;
        private Button btn_CreateUser;
        private Button btn_Retour;
    }
}
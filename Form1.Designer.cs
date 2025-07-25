namespace Arkone_Logiciel_Evenementiel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_VerifCode = new Button();
            txt_VerifCode = new TextBox();
            lbl_Code = new Label();
            btn_Retour = new Button();
            SuspendLayout();
            // 
            // btn_VerifCode
            // 
            btn_VerifCode.Location = new Point(284, 262);
            btn_VerifCode.Name = "btn_VerifCode";
            btn_VerifCode.Size = new Size(265, 76);
            btn_VerifCode.TabIndex = 0;
            btn_VerifCode.Text = "ENTRER";
            btn_VerifCode.UseVisualStyleBackColor = true;
            // 
            // txt_VerifCode
            // 
            txt_VerifCode.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_VerifCode.Location = new Point(154, 151);
            txt_VerifCode.Multiline = true;
            txt_VerifCode.Name = "txt_VerifCode";
            txt_VerifCode.Size = new Size(511, 105);
            txt_VerifCode.TabIndex = 1;
            txt_VerifCode.TextAlign = HorizontalAlignment.Center;
            txt_VerifCode.KeyPress += txt_VerifCode_KeyPress;
            // 
            // lbl_Code
            // 
            lbl_Code.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Code.Location = new Point(154, 81);
            lbl_Code.Name = "lbl_Code";
            lbl_Code.Size = new Size(507, 56);
            lbl_Code.TabIndex = 2;
            lbl_Code.Text = "Saisir le code d'accès : ";
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(6, 415);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(64, 29);
            btn_Retour.TabIndex = 3;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Retour);
            Controls.Add(lbl_Code);
            Controls.Add(txt_VerifCode);
            Controls.Add(btn_VerifCode);
            Name = "Form1";
            Text = "Arkone Agent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_VerifCode;
        private TextBox txt_VerifCode;
        private Label lbl_Code;
        private Button btn_Retour;
    }
}

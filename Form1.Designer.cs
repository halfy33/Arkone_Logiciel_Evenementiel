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
            btn_VerifCode.Location = new Point(248, 196);
            btn_VerifCode.Margin = new Padding(3, 2, 3, 2);
            btn_VerifCode.Name = "btn_VerifCode";
            btn_VerifCode.Size = new Size(232, 57);
            btn_VerifCode.TabIndex = 0;
            btn_VerifCode.Text = "ENTRER";
            btn_VerifCode.UseVisualStyleBackColor = true;
            btn_VerifCode.Click += btn_VerifCode_Click;
            // 
            // txt_VerifCode
            // 
            txt_VerifCode.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_VerifCode.Location = new Point(135, 113);
            txt_VerifCode.Margin = new Padding(3, 2, 3, 2);
            txt_VerifCode.Multiline = true;
            txt_VerifCode.Name = "txt_VerifCode";
            txt_VerifCode.Size = new Size(448, 80);
            txt_VerifCode.TabIndex = 1;
            txt_VerifCode.TextAlign = HorizontalAlignment.Center;
            txt_VerifCode.KeyPress += txt_VerifCode_KeyPress;
            // 
            // lbl_Code
            // 
            lbl_Code.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Code.Location = new Point(135, 61);
            lbl_Code.Name = "lbl_Code";
            lbl_Code.Size = new Size(444, 42);
            lbl_Code.TabIndex = 2;
            lbl_Code.Text = "Saisir le code d'accès : ";
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(5, 311);
            btn_Retour.Margin = new Padding(3, 2, 3, 2);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(56, 22);
            btn_Retour.TabIndex = 3;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_Retour);
            Controls.Add(lbl_Code);
            Controls.Add(txt_VerifCode);
            Controls.Add(btn_VerifCode);
            Margin = new Padding(3, 2, 3, 2);
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

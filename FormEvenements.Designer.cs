namespace Arkone_Logiciel_Evenementiel
{
    partial class FormEvenements
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
            listbox_evenement = new ListBox();
            btn_Retour = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 46);
            label1.TabIndex = 0;
            label1.Text = "Liste des Évènements";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listbox_evenement
            // 
            listbox_evenement.FormattingEnabled = true;
            listbox_evenement.Location = new Point(12, 58);
            listbox_evenement.Name = "listbox_evenement";
            listbox_evenement.Size = new Size(776, 344);
            listbox_evenement.TabIndex = 1;
            listbox_evenement.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(6, 414);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(64, 29);
            btn_Retour.TabIndex = 5;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // FormEvenements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Retour);
            Controls.Add(listbox_evenement);
            Controls.Add(label1);
            Name = "FormEvenements";
            Text = "FormEvenements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listbox_evenement;
        private Button btn_Retour;
    }
}
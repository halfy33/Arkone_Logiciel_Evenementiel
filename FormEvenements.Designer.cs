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
            textbox_recherchEvenement = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 5);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 0;
            label1.Text = "Liste des Évènements";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listbox_evenement
            // 
            listbox_evenement.FormattingEnabled = true;
            listbox_evenement.ItemHeight = 15;
            listbox_evenement.Location = new Point(10, 74);
            listbox_evenement.Margin = new Padding(3, 2, 3, 2);
            listbox_evenement.Name = "listbox_evenement";
            listbox_evenement.Size = new Size(680, 229);
            listbox_evenement.TabIndex = 1;
            listbox_evenement.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(5, 310);
            btn_Retour.Margin = new Padding(3, 2, 3, 2);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(56, 22);
            btn_Retour.TabIndex = 5;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // textbox_recherchEvenement
            // 
            textbox_recherchEvenement.Location = new Point(79, 45);
            textbox_recherchEvenement.Name = "textbox_recherchEvenement";
            textbox_recherchEvenement.Size = new Size(535, 23);
            textbox_recherchEvenement.TabIndex = 6;
            textbox_recherchEvenement.TextChanged += textbox_recherchEvenement_TextChanged;
            // 
            // FormEvenements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(textbox_recherchEvenement);
            Controls.Add(btn_Retour);
            Controls.Add(listbox_evenement);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEvenements";
            Text = "Arkone Events";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listbox_evenement;
        private Button btn_Retour;
        private TextBox textbox_recherchEvenement;
    }
}
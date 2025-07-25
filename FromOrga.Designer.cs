namespace Arkone_Logiciel_Evenementiel
{
    partial class FromOrga
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
            button1 = new Button();
            button2 = new Button();
            btn_Retour = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(103, 245);
            button1.Name = "button1";
            button1.Size = new Size(580, 114);
            button1.TabIndex = 0;
            button1.Text = "Consulter les événements";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(102, 82);
            button2.Name = "button2";
            button2.Size = new Size(580, 112);
            button2.TabIndex = 1;
            button2.Text = "Créer un événement";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(8, 413);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(64, 29);
            btn_Retour.TabIndex = 4;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // FromOrga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Retour);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FromOrga";
            Text = "Arkone Organisateur";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btn_Retour;
    }
}
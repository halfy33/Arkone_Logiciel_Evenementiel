﻿namespace Arkone_Logiciel_Evenementiel
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
            // FromOrga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FromOrga";
            Text = "Arkone Organisateur";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
namespace Arkone_Logiciel_Evenementiel
{
    partial class FormCreateEvent
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
            txt_nameEvent = new TextBox();
            txt_LieuEvent = new TextBox();
            txt_LatitudeEvent = new TextBox();
            txt_DateEvent = new TextBox();
            btn_CreateEvent = new Button();
            label5 = new Label();
            btn_Retour = new Button();
            label6 = new Label();
            txt_LongitudeEvent = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 96);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 328);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Date : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 218);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Latitude :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 156);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Lieu : ";
            // 
            // txt_nameEvent
            // 
            txt_nameEvent.Location = new Point(356, 90);
            txt_nameEvent.Name = "txt_nameEvent";
            txt_nameEvent.Size = new Size(125, 27);
            txt_nameEvent.TabIndex = 4;
            // 
            // txt_LieuEvent
            // 
            txt_LieuEvent.Location = new Point(356, 150);
            txt_LieuEvent.Name = "txt_LieuEvent";
            txt_LieuEvent.Size = new Size(125, 27);
            txt_LieuEvent.TabIndex = 5;
            // 
            // txt_LatitudeEvent
            // 
            txt_LatitudeEvent.Location = new Point(356, 211);
            txt_LatitudeEvent.Name = "txt_LatitudeEvent";
            txt_LatitudeEvent.Size = new Size(125, 27);
            txt_LatitudeEvent.TabIndex = 6;
            // 
            // txt_DateEvent
            // 
            txt_DateEvent.Location = new Point(356, 325);
            txt_DateEvent.Name = "txt_DateEvent";
            txt_DateEvent.Size = new Size(125, 27);
            txt_DateEvent.TabIndex = 7;
            // 
            // btn_CreateEvent
            // 
            btn_CreateEvent.Location = new Point(356, 375);
            btn_CreateEvent.Name = "btn_CreateEvent";
            btn_CreateEvent.Size = new Size(94, 29);
            btn_CreateEvent.TabIndex = 8;
            btn_CreateEvent.Text = "Créer";
            btn_CreateEvent.UseVisualStyleBackColor = true;
            btn_CreateEvent.Click += btn_CreateEvent_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(176, 19);
            label5.Name = "label5";
            label5.Size = new Size(500, 41);
            label5.TabIndex = 9;
            label5.Text = "Création d'un événement";
            // 
            // btn_Retour
            // 
            btn_Retour.Location = new Point(8, 413);
            btn_Retour.Name = "btn_Retour";
            btn_Retour.Size = new Size(64, 29);
            btn_Retour.TabIndex = 10;
            btn_Retour.Text = "Retour";
            btn_Retour.UseVisualStyleBackColor = true;
            btn_Retour.Click += btn_Retour_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 275);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 11;
            label6.Text = "Longitude :";
            // 
            // txt_LongitudeEvent
            // 
            txt_LongitudeEvent.Location = new Point(356, 270);
            txt_LongitudeEvent.Name = "txt_LongitudeEvent";
            txt_LongitudeEvent.Size = new Size(125, 27);
            txt_LongitudeEvent.TabIndex = 12;
            // 
            // FormCreateEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_LongitudeEvent);
            Controls.Add(label6);
            Controls.Add(btn_Retour);
            Controls.Add(label5);
            Controls.Add(btn_CreateEvent);
            Controls.Add(txt_DateEvent);
            Controls.Add(txt_LatitudeEvent);
            Controls.Add(txt_LieuEvent);
            Controls.Add(txt_nameEvent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreateEvent";
            Text = "Arkone Création Event";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nameEvent;
        private TextBox txt_LieuEvent;
        private TextBox txt_LatitudeEvent;
        private TextBox txt_DateEvent;
        private Button btn_CreateEvent;
        private Label label5;
        private Button btn_Retour;
        private Label label6;
        private TextBox txt_LongitudeEvent;
    }
}
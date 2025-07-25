namespace Arkone_Logiciel_Evenementiel
{
    partial class FormHome
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
            btn_ModuleAgent = new Button();
            s = new Button();
            SuspendLayout();
            // 
            // btn_ModuleAgent
            // 
            btn_ModuleAgent.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ModuleAgent.Location = new Point(175, 62);
            btn_ModuleAgent.Name = "btn_ModuleAgent";
            btn_ModuleAgent.Size = new Size(457, 132);
            btn_ModuleAgent.TabIndex = 0;
            btn_ModuleAgent.Text = "MODULE AGENT";
            btn_ModuleAgent.UseVisualStyleBackColor = true;
            // 
            // s
            // 
            s.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s.Location = new Point(175, 243);
            s.Name = "s";
            s.Size = new Size(457, 132);
            s.TabIndex = 1;
            s.Text = "MODULE ORGANISATEUR";
            s.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(s);
            Controls.Add(btn_ModuleAgent);
            Name = "FormHome";
            Text = "Accueil";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ModuleAgent;
        private Button s;
    }
}
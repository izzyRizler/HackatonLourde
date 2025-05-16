namespace HackatonLourd
{
    partial class Form3
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
            lbl_titreApp = new Label();
            btn_ajouterHackaton = new Button();
            btn_voirConference = new Button();
            btn_stats = new Button();
            btn_insciption = new Button();
            SuspendLayout();
            // 
            // lbl_titreApp
            // 
            lbl_titreApp.AutoSize = true;
            lbl_titreApp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titreApp.Location = new Point(202, 31);
            lbl_titreApp.Name = "lbl_titreApp";
            lbl_titreApp.Size = new Size(373, 40);
            lbl_titreApp.TabIndex = 0;
            lbl_titreApp.Text = "Bienvenue sur HackaOrga";
            // 
            // btn_ajouterHackaton
            // 
            btn_ajouterHackaton.BackColor = Color.LightSkyBlue;
            btn_ajouterHackaton.Location = new Point(43, 152);
            btn_ajouterHackaton.Name = "btn_ajouterHackaton";
            btn_ajouterHackaton.Size = new Size(265, 51);
            btn_ajouterHackaton.TabIndex = 1;
            btn_ajouterHackaton.Text = "Ajouter un hackaton";
            btn_ajouterHackaton.UseVisualStyleBackColor = false;
            btn_ajouterHackaton.Click += btn_ajouterHackaton_Click;
            // 
            // btn_voirConference
            // 
            btn_voirConference.BackColor = Color.LightSkyBlue;
            btn_voirConference.Location = new Point(453, 152);
            btn_voirConference.Name = "btn_voirConference";
            btn_voirConference.Size = new Size(265, 51);
            btn_voirConference.TabIndex = 2;
            btn_voirConference.Text = "Voir les conférence";
            btn_voirConference.UseVisualStyleBackColor = false;
            btn_voirConference.Click += btn_voirConference_Click;
            // 
            // btn_stats
            // 
            btn_stats.BackColor = Color.LightSkyBlue;
            btn_stats.Location = new Point(43, 253);
            btn_stats.Name = "btn_stats";
            btn_stats.Size = new Size(265, 51);
            btn_stats.TabIndex = 3;
            btn_stats.Text = "Voir les statistiques";
            btn_stats.UseVisualStyleBackColor = false;
            btn_stats.Click += btn_stats_Click;
            // 
            // btn_insciption
            // 
            btn_insciption.BackColor = Color.LightSkyBlue;
            btn_insciption.Location = new Point(453, 244);
            btn_insciption.Name = "btn_insciption";
            btn_insciption.Size = new Size(265, 51);
            btn_insciption.TabIndex = 4;
            btn_insciption.Text = "Particper à un ateliers";
            btn_insciption.UseVisualStyleBackColor = false;
            btn_insciption.Click += btn_insciption_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_insciption);
            Controls.Add(btn_stats);
            Controls.Add(btn_voirConference);
            Controls.Add(btn_ajouterHackaton);
            Controls.Add(lbl_titreApp);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titreApp;
        private Button btn_ajouterHackaton;
        private Button btn_voirConference;
        private Button btn_stats;
        private Button btn_insciption;
    }
}
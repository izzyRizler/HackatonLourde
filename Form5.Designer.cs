namespace HackatonLourd
{
    partial class Form5
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
            lbl_nbPlace = new Label();
            lbl_dateLimite = new Label();
            lbl_theme = new Label();
            lbl_dateDebut = new Label();
            lbl_dateFin = new Label();
            lbl_heureDebut = new Label();
            lbl_heureFin = new Label();
            lbl_ville = new Label();
            textBox1 = new TextBox();
            lbl_codePostale = new Label();
            lbl_rue = new Label();
            tbx_theme = new TextBox();
            tbx_heureDebut = new TextBox();
            tbx_heureFin = new TextBox();
            tbx_ville = new TextBox();
            dateLimite = new DateTimePicker();
            dateDebut = new DateTimePicker();
            dateFin = new DateTimePicker();
            tbx_codePostal = new TextBox();
            tbx_rue = new TextBox();
            cbx_hackaton = new ComboBox();
            lbl_hackaton = new Label();
            btn_ajouHackaton = new Button();
            btn_modifierHackaton = new Button();
            btn_supprimerHackaton = new Button();
            btn_ajoutAteliers = new Button();
            btn_ajoutConference = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_nbPlace
            // 
            lbl_nbPlace.AutoSize = true;
            lbl_nbPlace.Location = new Point(3, 35);
            lbl_nbPlace.Name = "lbl_nbPlace";
            lbl_nbPlace.Size = new Size(101, 15);
            lbl_nbPlace.TabIndex = 0;
            lbl_nbPlace.Text = "Nombre de place ";
            // 
            // lbl_dateLimite
            // 
            lbl_dateLimite.AutoSize = true;
            lbl_dateLimite.Location = new Point(12, 86);
            lbl_dateLimite.Name = "lbl_dateLimite";
            lbl_dateLimite.Size = new Size(64, 15);
            lbl_dateLimite.TabIndex = 1;
            lbl_dateLimite.Text = "Date limite";
            // 
            // lbl_theme
            // 
            lbl_theme.AutoSize = true;
            lbl_theme.Location = new Point(12, 149);
            lbl_theme.Name = "lbl_theme";
            lbl_theme.Size = new Size(43, 15);
            lbl_theme.TabIndex = 2;
            lbl_theme.Text = "Theme";
            // 
            // lbl_dateDebut
            // 
            lbl_dateDebut.AutoSize = true;
            lbl_dateDebut.Location = new Point(12, 213);
            lbl_dateDebut.Name = "lbl_dateDebut";
            lbl_dateDebut.Size = new Size(81, 15);
            lbl_dateDebut.TabIndex = 3;
            lbl_dateDebut.Text = "Date de debut";
            // 
            // lbl_dateFin
            // 
            lbl_dateFin.AutoSize = true;
            lbl_dateFin.Location = new Point(12, 268);
            lbl_dateFin.Name = "lbl_dateFin";
            lbl_dateFin.Size = new Size(64, 15);
            lbl_dateFin.TabIndex = 4;
            lbl_dateFin.Text = "Date de fin";
            // 
            // lbl_heureDebut
            // 
            lbl_heureDebut.AutoSize = true;
            lbl_heureDebut.Location = new Point(15, 325);
            lbl_heureDebut.Name = "lbl_heureDebut";
            lbl_heureDebut.Size = new Size(89, 15);
            lbl_heureDebut.TabIndex = 5;
            lbl_heureDebut.Text = "Heure de début";
            // 
            // lbl_heureFin
            // 
            lbl_heureFin.AutoSize = true;
            lbl_heureFin.Location = new Point(21, 382);
            lbl_heureFin.Name = "lbl_heureFin";
            lbl_heureFin.Size = new Size(72, 15);
            lbl_heureFin.TabIndex = 6;
            lbl_heureFin.Text = "Heure de fin";
            // 
            // lbl_ville
            // 
            lbl_ville.AutoSize = true;
            lbl_ville.Location = new Point(21, 444);
            lbl_ville.Name = "lbl_ville";
            lbl_ville.Size = new Size(29, 15);
            lbl_ville.TabIndex = 7;
            lbl_ville.Text = "Ville";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbl_codePostale
            // 
            lbl_codePostale.AutoSize = true;
            lbl_codePostale.Location = new Point(358, 30);
            lbl_codePostale.Name = "lbl_codePostale";
            lbl_codePostale.Size = new Size(70, 15);
            lbl_codePostale.TabIndex = 9;
            lbl_codePostale.Text = "Code postal";
            // 
            // lbl_rue
            // 
            lbl_rue.AutoSize = true;
            lbl_rue.Location = new Point(384, 101);
            lbl_rue.Name = "lbl_rue";
            lbl_rue.Size = new Size(27, 15);
            lbl_rue.TabIndex = 10;
            lbl_rue.Text = "Rue";
            // 
            // tbx_theme
            // 
            tbx_theme.Location = new Point(125, 141);
            tbx_theme.Name = "tbx_theme";
            tbx_theme.Size = new Size(248, 23);
            tbx_theme.TabIndex = 12;
            // 
            // tbx_heureDebut
            // 
            tbx_heureDebut.Location = new Point(125, 322);
            tbx_heureDebut.Name = "tbx_heureDebut";
            tbx_heureDebut.Size = new Size(248, 23);
            tbx_heureDebut.TabIndex = 15;
            // 
            // tbx_heureFin
            // 
            tbx_heureFin.Location = new Point(125, 374);
            tbx_heureFin.Name = "tbx_heureFin";
            tbx_heureFin.Size = new Size(248, 23);
            tbx_heureFin.TabIndex = 16;
            // 
            // tbx_ville
            // 
            tbx_ville.Location = new Point(125, 441);
            tbx_ville.Name = "tbx_ville";
            tbx_ville.Size = new Size(248, 23);
            tbx_ville.TabIndex = 17;
            // 
            // dateLimite
            // 
            dateLimite.Location = new Point(125, 86);
            dateLimite.Name = "dateLimite";
            dateLimite.Size = new Size(200, 23);
            dateLimite.TabIndex = 18;
            // 
            // dateDebut
            // 
            dateDebut.Location = new Point(125, 207);
            dateDebut.Name = "dateDebut";
            dateDebut.Size = new Size(200, 23);
            dateDebut.TabIndex = 19;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(125, 262);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(200, 23);
            dateFin.TabIndex = 20;
            // 
            // tbx_codePostal
            // 
            tbx_codePostal.Location = new Point(434, 22);
            tbx_codePostal.Name = "tbx_codePostal";
            tbx_codePostal.Size = new Size(164, 23);
            tbx_codePostal.TabIndex = 21;
            // 
            // tbx_rue
            // 
            tbx_rue.Location = new Point(434, 93);
            tbx_rue.Name = "tbx_rue";
            tbx_rue.Size = new Size(164, 23);
            tbx_rue.TabIndex = 22;
            // 
            // cbx_hackaton
            // 
            cbx_hackaton.FormattingEnabled = true;
            cbx_hackaton.Location = new Point(796, 22);
            cbx_hackaton.Name = "cbx_hackaton";
            cbx_hackaton.Size = new Size(203, 23);
            cbx_hackaton.TabIndex = 23;
            cbx_hackaton.SelectedIndexChanged += cbx_hackaton_SelectedIndexChanged;
            // 
            // lbl_hackaton
            // 
            lbl_hackaton.AutoSize = true;
            lbl_hackaton.Location = new Point(678, 27);
            lbl_hackaton.Name = "lbl_hackaton";
            lbl_hackaton.Size = new Size(112, 15);
            lbl_hackaton.TabIndex = 24;
            lbl_hackaton.Text = "Choix de l'hackaton";
            // 
            // btn_ajouHackaton
            // 
            btn_ajouHackaton.Location = new Point(768, 86);
            btn_ajouHackaton.Name = "btn_ajouHackaton";
            btn_ajouHackaton.Size = new Size(242, 35);
            btn_ajouHackaton.TabIndex = 25;
            btn_ajouHackaton.Text = "Ajouter  l'hackaton";
            btn_ajouHackaton.UseVisualStyleBackColor = true;
            btn_ajouHackaton.Click += btn_ajouHackaton_Click;
            // 
            // btn_modifierHackaton
            // 
            btn_modifierHackaton.Location = new Point(768, 139);
            btn_modifierHackaton.Name = "btn_modifierHackaton";
            btn_modifierHackaton.Size = new Size(242, 35);
            btn_modifierHackaton.TabIndex = 26;
            btn_modifierHackaton.Text = "Modifier le hackaton";
            btn_modifierHackaton.UseVisualStyleBackColor = true;
            btn_modifierHackaton.Click += btn_modifierHackaton_Click;
            // 
            // btn_supprimerHackaton
            // 
            btn_supprimerHackaton.Location = new Point(768, 195);
            btn_supprimerHackaton.Name = "btn_supprimerHackaton";
            btn_supprimerHackaton.Size = new Size(242, 35);
            btn_supprimerHackaton.TabIndex = 27;
            btn_supprimerHackaton.Text = "Supprimer le hackaton";
            btn_supprimerHackaton.UseVisualStyleBackColor = true;
            btn_supprimerHackaton.Click += btn_supprimerHackaton_Click;
            // 
            // btn_ajoutAteliers
            // 
            btn_ajoutAteliers.Location = new Point(768, 268);
            btn_ajoutAteliers.Name = "btn_ajoutAteliers";
            btn_ajoutAteliers.Size = new Size(242, 35);
            btn_ajoutAteliers.TabIndex = 28;
            btn_ajoutAteliers.Text = "Ajouter un ateliers";
            btn_ajoutAteliers.UseVisualStyleBackColor = true;
            btn_ajoutAteliers.Click += btn_ajoutAteliers_Click;
            // 
            // btn_ajoutConference
            // 
            btn_ajoutConference.Location = new Point(768, 334);
            btn_ajoutConference.Name = "btn_ajoutConference";
            btn_ajoutConference.Size = new Size(242, 35);
            btn_ajoutConference.TabIndex = 29;
            btn_ajoutConference.Text = "Ajouter une conférence";
            btn_ajoutConference.UseVisualStyleBackColor = true;
            btn_ajoutConference.Click += btn_ajoutConference_Click;
            // 
            // button1
            // 
            button1.Location = new Point(768, 394);
            button1.Name = "button1";
            button1.Size = new Size(242, 35);
            button1.TabIndex = 30;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 485);
            Controls.Add(button1);
            Controls.Add(btn_ajoutConference);
            Controls.Add(btn_ajoutAteliers);
            Controls.Add(btn_supprimerHackaton);
            Controls.Add(btn_modifierHackaton);
            Controls.Add(btn_ajouHackaton);
            Controls.Add(lbl_hackaton);
            Controls.Add(cbx_hackaton);
            Controls.Add(tbx_rue);
            Controls.Add(tbx_codePostal);
            Controls.Add(dateFin);
            Controls.Add(dateDebut);
            Controls.Add(dateLimite);
            Controls.Add(tbx_ville);
            Controls.Add(tbx_heureFin);
            Controls.Add(tbx_heureDebut);
            Controls.Add(tbx_theme);
            Controls.Add(lbl_rue);
            Controls.Add(lbl_codePostale);
            Controls.Add(textBox1);
            Controls.Add(lbl_ville);
            Controls.Add(lbl_heureFin);
            Controls.Add(lbl_heureDebut);
            Controls.Add(lbl_dateFin);
            Controls.Add(lbl_dateDebut);
            Controls.Add(lbl_theme);
            Controls.Add(lbl_dateLimite);
            Controls.Add(lbl_nbPlace);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nbPlace;
        private Label lbl_dateLimite;
        private Label lbl_theme;
        private Label lbl_dateDebut;
        private Label lbl_dateFin;
        private Label lbl_heureDebut;
        private Label lbl_heureFin;
        private Label lbl_ville;
        private TextBox textBox1;
        private Label lbl_codePostale;
        private Label lbl_rue;
        private TextBox tbx_theme;
        private TextBox tbx_heureDebut;
        private TextBox tbx_heureFin;
        private TextBox tbx_ville;
        private DateTimePicker dateLimite;
        private DateTimePicker dateDebut;
        private DateTimePicker dateFin;
        private TextBox tbx_codePostal;
        private TextBox tbx_rue;
        private ComboBox cbx_hackaton;
        private Label lbl_hackaton;
        private Button btn_ajouHackaton;
        private Button btn_modifierHackaton;
        private Button btn_supprimerHackaton;
        private Button btn_ajoutAteliers;
        private Button btn_ajoutConference;
        private Button button1;
    }
}
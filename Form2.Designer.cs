namespace HackatonLourd
{
    partial class Form2
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
            champDateEvent = new DateTimePicker();
            lbl_dateEvent = new Label();
            lbl_heureEvent = new Label();
            lbl_duree = new Label();
            lbl_salle = new Label();
            lbl_place = new Label();
            tbx_heureEvent = new TextBox();
            tbx_NomSalle = new TextBox();
            tbx_themeConference = new TextBox();
            tbx_nomIntervenant = new TextBox();
            lbl_nomIntervenant = new Label();
            lbl_themeConference = new Label();
            champ_Duree = new NumericUpDown();
            champ_nbPlace = new NumericUpDown();
            btn_conférence = new Button();
            btn_atelier = new Button();
            lbl_id = new Label();
            tbx_MailIntervenant = new TextBox();
            lbl_mailIntervenant = new Label();
            btn_retour = new Button();
            ((System.ComponentModel.ISupportInitialize)champ_Duree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)champ_nbPlace).BeginInit();
            SuspendLayout();
            // 
            // champDateEvent
            // 
            champDateEvent.Location = new Point(134, 56);
            champDateEvent.Name = "champDateEvent";
            champDateEvent.Size = new Size(200, 23);
            champDateEvent.TabIndex = 0;
            // 
            // lbl_dateEvent
            // 
            lbl_dateEvent.AutoSize = true;
            lbl_dateEvent.Location = new Point(26, 60);
            lbl_dateEvent.Name = "lbl_dateEvent";
            lbl_dateEvent.Size = new Size(88, 15);
            lbl_dateEvent.TabIndex = 1;
            lbl_dateEvent.Text = "Date de l'event:";
            // 
            // lbl_heureEvent
            // 
            lbl_heureEvent.AutoSize = true;
            lbl_heureEvent.Location = new Point(26, 134);
            lbl_heureEvent.Name = "lbl_heureEvent";
            lbl_heureEvent.Size = new Size(93, 15);
            lbl_heureEvent.TabIndex = 2;
            lbl_heureEvent.Text = "Heure de l'event";
            // 
            // lbl_duree
            // 
            lbl_duree.AutoSize = true;
            lbl_duree.Location = new Point(26, 223);
            lbl_duree.Name = "lbl_duree";
            lbl_duree.Size = new Size(92, 15);
            lbl_duree.TabIndex = 3;
            lbl_duree.Text = "Duree de l'event";
            // 
            // lbl_salle
            // 
            lbl_salle.AutoSize = true;
            lbl_salle.Location = new Point(26, 289);
            lbl_salle.Name = "lbl_salle";
            lbl_salle.Size = new Size(91, 15);
            lbl_salle.TabIndex = 4;
            lbl_salle.Text = "Nom de la salle ";
            // 
            // lbl_place
            // 
            lbl_place.AutoSize = true;
            lbl_place.Location = new Point(26, 367);
            lbl_place.Name = "lbl_place";
            lbl_place.Size = new Size(98, 15);
            lbl_place.TabIndex = 5;
            lbl_place.Text = "Nombre de place";
            // 
            // tbx_heureEvent
            // 
            tbx_heureEvent.Location = new Point(134, 126);
            tbx_heureEvent.Name = "tbx_heureEvent";
            tbx_heureEvent.Size = new Size(203, 23);
            tbx_heureEvent.TabIndex = 6;
            // 
            // tbx_NomSalle
            // 
            tbx_NomSalle.Location = new Point(131, 281);
            tbx_NomSalle.Name = "tbx_NomSalle";
            tbx_NomSalle.Size = new Size(203, 23);
            tbx_NomSalle.TabIndex = 7;
            // 
            // tbx_themeConference
            // 
            tbx_themeConference.Location = new Point(412, 170);
            tbx_themeConference.Multiline = true;
            tbx_themeConference.Name = "tbx_themeConference";
            tbx_themeConference.Size = new Size(203, 48);
            tbx_themeConference.TabIndex = 8;
            // 
            // tbx_nomIntervenant
            // 
            tbx_nomIntervenant.Location = new Point(412, 245);
            tbx_nomIntervenant.Multiline = true;
            tbx_nomIntervenant.Name = "tbx_nomIntervenant";
            tbx_nomIntervenant.Size = new Size(203, 46);
            tbx_nomIntervenant.TabIndex = 9;
            // 
            // lbl_nomIntervenant
            // 
            lbl_nomIntervenant.AutoSize = true;
            lbl_nomIntervenant.Location = new Point(457, 227);
            lbl_nomIntervenant.Name = "lbl_nomIntervenant";
            lbl_nomIntervenant.Size = new Size(119, 15);
            lbl_nomIntervenant.TabIndex = 10;
            lbl_nomIntervenant.Text = "Nom de l'intervenant";
            // 
            // lbl_themeConference
            // 
            lbl_themeConference.AutoSize = true;
            lbl_themeConference.Location = new Point(457, 152);
            lbl_themeConference.Name = "lbl_themeConference";
            lbl_themeConference.Size = new Size(133, 15);
            lbl_themeConference.TabIndex = 11;
            lbl_themeConference.Text = "Theme de la conférence";
            // 
            // champ_Duree
            // 
            champ_Duree.Location = new Point(134, 217);
            champ_Duree.Name = "champ_Duree";
            champ_Duree.Size = new Size(120, 23);
            champ_Duree.TabIndex = 12;
            // 
            // champ_nbPlace
            // 
            champ_nbPlace.Location = new Point(138, 361);
            champ_nbPlace.Name = "champ_nbPlace";
            champ_nbPlace.Size = new Size(120, 23);
            champ_nbPlace.TabIndex = 13;
            // 
            // btn_conférence
            // 
            btn_conférence.Location = new Point(446, 350);
            btn_conférence.Name = "btn_conférence";
            btn_conférence.Size = new Size(144, 23);
            btn_conférence.TabIndex = 14;
            btn_conférence.Text = "Ajouter une conférence";
            btn_conférence.UseVisualStyleBackColor = true;
            btn_conférence.Click += btn_conférence_Click;
            // 
            // btn_atelier
            // 
            btn_atelier.Location = new Point(457, 392);
            btn_atelier.Name = "btn_atelier";
            btn_atelier.Size = new Size(119, 23);
            btn_atelier.TabIndex = 15;
            btn_atelier.Text = "Ajouter un atelier";
            btn_atelier.UseVisualStyleBackColor = true;
            btn_atelier.Click += btn_atelier_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(426, 36);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(0, 15);
            lbl_id.TabIndex = 16;
            // 
            // tbx_MailIntervenant
            // 
            tbx_MailIntervenant.Location = new Point(377, 321);
            tbx_MailIntervenant.Name = "tbx_MailIntervenant";
            tbx_MailIntervenant.Size = new Size(284, 23);
            tbx_MailIntervenant.TabIndex = 17;
            // 
            // lbl_mailIntervenant
            // 
            lbl_mailIntervenant.AutoSize = true;
            lbl_mailIntervenant.Location = new Point(457, 303);
            lbl_mailIntervenant.Name = "lbl_mailIntervenant";
            lbl_mailIntervenant.Size = new Size(121, 15);
            lbl_mailIntervenant.TabIndex = 18;
            lbl_mailIntervenant.Text = "Email de l'intervenant";
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(669, 415);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(119, 23);
            btn_retour.TabIndex = 19;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.Click += btn_retour_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_retour);
            Controls.Add(lbl_mailIntervenant);
            Controls.Add(tbx_MailIntervenant);
            Controls.Add(lbl_id);
            Controls.Add(btn_atelier);
            Controls.Add(btn_conférence);
            Controls.Add(champ_nbPlace);
            Controls.Add(champ_Duree);
            Controls.Add(lbl_themeConference);
            Controls.Add(lbl_nomIntervenant);
            Controls.Add(tbx_nomIntervenant);
            Controls.Add(tbx_themeConference);
            Controls.Add(tbx_NomSalle);
            Controls.Add(tbx_heureEvent);
            Controls.Add(lbl_place);
            Controls.Add(lbl_salle);
            Controls.Add(lbl_duree);
            Controls.Add(lbl_heureEvent);
            Controls.Add(lbl_dateEvent);
            Controls.Add(champDateEvent);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)champ_Duree).EndInit();
            ((System.ComponentModel.ISupportInitialize)champ_nbPlace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker champDateEvent;
        private Label lbl_dateEvent;
        private Label lbl_heureEvent;
        private Label lbl_duree;
        private Label lbl_salle;
        private Label lbl_place;
        private TextBox tbx_heureEvent;
        private TextBox tbx_NomSalle;
        private TextBox tbx_themeConference;
        private TextBox tbx_nomIntervenant;
        private Label lbl_nomIntervenant;
        private Label lbl_themeConference;
        private NumericUpDown champ_Duree;
        private NumericUpDown champ_nbPlace;
        private Button btn_conférence;
        private Button btn_atelier;
        private Label lbl_id;
        private TextBox tbx_MailIntervenant;
        private Label lbl_mailIntervenant;
        private Button btn_retour;
    }
}
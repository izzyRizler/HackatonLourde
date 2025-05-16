namespace HackatonLourd
{
    partial class Form4
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
            liste_eventConference = new CheckedListBox();
            btn_envoi_mail = new Button();
            btn_retour = new Button();
            SuspendLayout();
            // 
            // liste_eventConference
            // 
            liste_eventConference.FormattingEnabled = true;
            liste_eventConference.Location = new Point(49, 20);
            liste_eventConference.Name = "liste_eventConference";
            liste_eventConference.Size = new Size(722, 202);
            liste_eventConference.TabIndex = 0;
            liste_eventConference.SelectedIndexChanged += liste_eventConference_SelectedIndexChanged;
            // 
            // btn_envoi_mail
            // 
            btn_envoi_mail.Location = new Point(596, 239);
            btn_envoi_mail.Name = "btn_envoi_mail";
            btn_envoi_mail.Size = new Size(175, 37);
            btn_envoi_mail.TabIndex = 1;
            btn_envoi_mail.Text = "Envoyer un mail";
            btn_envoi_mail.UseVisualStyleBackColor = true;
            btn_envoi_mail.Click += btn_envoi_mail_Click;
            // 
            // btn_retour
            // 
            btn_retour.Location = new Point(596, 297);
            btn_retour.Name = "btn_retour";
            btn_retour.Size = new Size(175, 39);
            btn_retour.TabIndex = 2;
            btn_retour.Text = "Retour";
            btn_retour.UseVisualStyleBackColor = true;
            btn_retour.Click += btn_retour_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_retour);
            Controls.Add(btn_envoi_mail);
            Controls.Add(liste_eventConference);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox liste_eventConference;
        private Button btn_envoi_mail;
        private Button btn_retour;
    }
}
namespace HackatonLourd
{
    partial class Inscription
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
            cbx_themeAtelier = new ComboBox();
            lbl_theme = new Label();
            lbl_ateliers = new Label();
            cbx_heureAtelier = new ComboBox();
            lbl_heureAteliers = new Label();
            lbl_don = new Label();
            lbl_montant = new Label();
            valeurMontant = new NumericUpDown();
            btn_inscript = new Button();
            ((System.ComponentModel.ISupportInitialize)valeurMontant).BeginInit();
            SuspendLayout();
            // 
            // cbx_themeAtelier
            // 
            cbx_themeAtelier.FormattingEnabled = true;
            cbx_themeAtelier.Location = new Point(102, 123);
            cbx_themeAtelier.Name = "cbx_themeAtelier";
            cbx_themeAtelier.Size = new Size(340, 23);
            cbx_themeAtelier.TabIndex = 0;
            cbx_themeAtelier.SelectedIndexChanged += cbx_themeAtelier_SelectedIndexChanged;
            // 
            // lbl_theme
            // 
            lbl_theme.AutoSize = true;
            lbl_theme.Location = new Point(31, 126);
            lbl_theme.Name = "lbl_theme";
            lbl_theme.Size = new Size(43, 15);
            lbl_theme.TabIndex = 1;
            lbl_theme.Text = "Thème";
            // 
            // lbl_ateliers
            // 
            lbl_ateliers.AutoSize = true;
            lbl_ateliers.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ateliers.Location = new Point(285, 34);
            lbl_ateliers.Name = "lbl_ateliers";
            lbl_ateliers.Size = new Size(142, 45);
            lbl_ateliers.TabIndex = 2;
            lbl_ateliers.Text = "Atelier";
            // 
            // cbx_heureAtelier
            // 
            cbx_heureAtelier.FormattingEnabled = true;
            cbx_heureAtelier.Location = new Point(140, 184);
            cbx_heureAtelier.Name = "cbx_heureAtelier";
            cbx_heureAtelier.Size = new Size(340, 23);
            cbx_heureAtelier.TabIndex = 3;
            cbx_heureAtelier.SelectedIndexChanged += cbx_heureAtelier_SelectedIndexChanged;
            // 
            // lbl_heureAteliers
            // 
            lbl_heureAteliers.AutoSize = true;
            lbl_heureAteliers.Location = new Point(31, 187);
            lbl_heureAteliers.Name = "lbl_heureAteliers";
            lbl_heureAteliers.Size = new Size(103, 15);
            lbl_heureAteliers.TabIndex = 4;
            lbl_heureAteliers.Text = "L'heure de l'atelier";
            // 
            // lbl_don
            // 
            lbl_don.AutoSize = true;
            lbl_don.Location = new Point(31, 250);
            lbl_don.Name = "lbl_don";
            lbl_don.Size = new Size(76, 15);
            lbl_don.TabIndex = 5;
            lbl_don.Text = " Faire un don";
            // 
            // lbl_montant
            // 
            lbl_montant.AutoSize = true;
            lbl_montant.Location = new Point(31, 287);
            lbl_montant.Name = "lbl_montant";
            lbl_montant.Size = new Size(103, 15);
            lbl_montant.TabIndex = 6;
            lbl_montant.Text = "Si oui, le montant ";
            // 
            // valeurMontant
            // 
            valeurMontant.Location = new Point(140, 279);
            valeurMontant.Name = "valeurMontant";
            valeurMontant.Size = new Size(120, 23);
            valeurMontant.TabIndex = 7;
            // 
            // btn_inscript
            // 
            btn_inscript.Location = new Point(31, 339);
            btn_inscript.Name = "btn_inscript";
            btn_inscript.Size = new Size(93, 39);
            btn_inscript.TabIndex = 8;
            btn_inscript.Text = "Je m'inscrit";
            btn_inscript.UseVisualStyleBackColor = true;
            btn_inscript.Click += btn_inscript_Click;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_inscript);
            Controls.Add(valeurMontant);
            Controls.Add(lbl_montant);
            Controls.Add(lbl_don);
            Controls.Add(lbl_heureAteliers);
            Controls.Add(cbx_heureAtelier);
            Controls.Add(lbl_ateliers);
            Controls.Add(lbl_theme);
            Controls.Add(cbx_themeAtelier);
            Name = "Inscription";
            Text = "Inscription";
            Load += Inscription_Load;
            ((System.ComponentModel.ISupportInitialize)valeurMontant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_themeAtelier;
        private Label lbl_theme;
        private Label lbl_ateliers;
        private ComboBox cbx_heureAtelier;
        private Label lbl_heureAteliers;
        private Label lbl_don;
        private Label lbl_montant;
        private NumericUpDown valeurMontant;
        private Button btn_inscript;
    }
}
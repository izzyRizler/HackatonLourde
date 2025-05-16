namespace HackatonLourd
{
    partial class Statistique
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
            lbl_stats = new Label();
            btn_statsHack = new Button();
            btn_statsAtelier = new Button();
            dataGridView1 = new DataGridView();
            btn_retour_stats = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_stats
            // 
            lbl_stats.AutoSize = true;
            lbl_stats.Font = new Font("Segoe UI", 20F);
            lbl_stats.Location = new Point(428, 52);
            lbl_stats.Name = "lbl_stats";
            lbl_stats.Size = new Size(141, 37);
            lbl_stats.TabIndex = 0;
            lbl_stats.Text = "Statistique";
            // 
            // btn_statsHack
            // 
            btn_statsHack.Location = new Point(82, 161);
            btn_statsHack.Name = "btn_statsHack";
            btn_statsHack.Size = new Size(219, 56);
            btn_statsHack.TabIndex = 1;
            btn_statsHack.Text = "Hackaton";
            btn_statsHack.UseVisualStyleBackColor = true;
            btn_statsHack.Click += btn_statsHack_Click;
            // 
            // btn_statsAtelier
            // 
            btn_statsAtelier.Location = new Point(82, 242);
            btn_statsAtelier.Name = "btn_statsAtelier";
            btn_statsAtelier.Size = new Size(219, 55);
            btn_statsAtelier.TabIndex = 2;
            btn_statsAtelier.Text = "Ateliers ";
            btn_statsAtelier.UseVisualStyleBackColor = true;
            btn_statsAtelier.Click += btn_statsAtelier_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(387, 448);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_retour_stats
            // 
            btn_retour_stats.Location = new Point(119, 332);
            btn_retour_stats.Name = "btn_retour_stats";
            btn_retour_stats.Size = new Size(148, 42);
            btn_retour_stats.TabIndex = 5;
            btn_retour_stats.Text = "Ok";
            btn_retour_stats.UseVisualStyleBackColor = true;
            btn_retour_stats.Click += btn_retour_stats_Click;
            // 
            // Statistique
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 562);
            Controls.Add(btn_retour_stats);
            Controls.Add(dataGridView1);
            Controls.Add(btn_statsAtelier);
            Controls.Add(btn_statsHack);
            Controls.Add(lbl_stats);
            Name = "Statistique";
            Text = "Statistique";
            Load += Statistique_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_stats;
        private Button btn_statsHack;
        private Button btn_statsAtelier;
        private DataGridView dataGridView1;
        private Button btn_retour_stats;
    }
}
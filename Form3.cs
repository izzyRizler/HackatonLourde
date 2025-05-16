using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackatonLourd.Models;
namespace HackatonLourd
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_ajouterHackaton_Click(object sender, EventArgs e)
        {
            Form5 formHack = new Form5();
            formHack.Show();
            this.Hide();
        }

        private void btn_voirConference_Click(object sender, EventArgs e)
        {
            Form4 formliste = new Form4();
            formliste.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            Statistique formliste = new Statistique();
            formliste.Show();
            this.Hide();
        }

        private void btn_insciption_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Hide();
        }
    }
}

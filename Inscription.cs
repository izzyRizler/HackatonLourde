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
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Engines;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HackatonLourd
{
    public partial class Inscription : Form
    {
        ArasoharimalalaHackatContext cnx = new ArasoharimalalaHackatContext();
        public Inscription()
        {
            InitializeComponent();
        }

        private void cbx_themeAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_themeAtelier.SelectedItem != null)
            {
                Hackaton unHackaton = (Hackaton)cbx_themeAtelier.SelectedItem;
                int id = unHackaton.Idhack;
                cbx_heureAtelier.SelectedIndexChanged -= cbx_heureAtelier_SelectedIndexChanged;
                cbx_heureAtelier.DataSource = cnx.Eventateliers.Where(e => e.Idhack == id).ToList();
                cbx_heureAtelier.DisplayMember = "HEUREEVENT";
                cbx_heureAtelier.ValueMember = "IDHACK";
                cbx_heureAtelier.SelectedIndexChanged += cbx_heureAtelier_SelectedIndexChanged;
            }
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            cbx_themeAtelier.SelectedIndexChanged -= cbx_themeAtelier_SelectedIndexChanged;
            cbx_themeAtelier.DataSource = cnx.Hackatons.Include(h => h.Eventateliers).OrderBy(cli => cli.Themehack).ToList();
            cbx_themeAtelier.DisplayMember = "THEMEHACK";
            cbx_themeAtelier.ValueMember = "IDHACK";
            cbx_themeAtelier.SelectedIndexChanged += cbx_themeAtelier_SelectedIndexChanged;
        }

        private void cbx_heureAtelier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_inscript_Click(object sender, EventArgs e)
        {  
            Inscription i = new Inscription();
            
            
            
        }
    }
}

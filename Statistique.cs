using HackatonLourd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonLourd
{
    public partial class Statistique : Form
    {

        ArasoharimalalaHackatContext cnx = new ArasoharimalalaHackatContext();
        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {

        }

        private void btn_statsHack_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cnx.Hackatons
                               .Join(cnx.Inscriptions,
                                     hackaton => hackaton.Idhack,
                                     inscription => inscription.Idhack,
                                     (hackaton, inscription) => new
                                     {
                                         hackaton.Themehack,
                                         hackaton.Nbplaceshack
                                     })
                               .GroupBy(x => new { x.Themehack, x.Nbplaceshack })
                               .Select(g => new
                               {
                                   ThemeHack = g.Key.Themehack,
                                   Participants = g.Count(),
                                   PlacesDisponibles = g.Key.Nbplaceshack,
                                   MoinsDeMoitie = g.Count() < (g.Key.Nbplaceshack / 2)
                               })
                               .ToList();


        }

        private void btn_statsAtelier_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cnx.Utilisateurs
                              .SelectMany(utilisateur => utilisateur.Idevents, (utilisateur, eventAteliers) => new
                              {
                                  EventAtelierId = eventAteliers.Idevent,
                                  eventAteliers.Nbparticipants
                              })
                              .GroupBy(x => new { x.EventAtelierId, x.Nbparticipants })
                              .Select(g => new
                              {
                                  EventAtelierId = g.Key.EventAtelierId,
                                  Participants = g.Count(),
                                  PlacesDisponibles = g.Key.Nbparticipants,
                                  MoinsDeMoitie = g.Count() < (g.Key.Nbparticipants / 2)
                              })
                              .ToList();
        }

        private void btn_statsConf_Click(object sender, EventArgs e)
        {

        }

        private void btn_retour_stats_Click(object sender, EventArgs e)
        {
            Form3 formliste = new Form3();
            formliste.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

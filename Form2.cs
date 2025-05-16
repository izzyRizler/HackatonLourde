using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackatonLourd.Models;

namespace HackatonLourd
{
    public partial class Form2 : Form
    {
        private ArasoharimalalaHackatContext cnx;
        private int idHAck;
        public Form2(int id, String type)
        {
            InitializeComponent();

            cnx = new ArasoharimalalaHackatContext();
            idHAck = id;
            lbl_id.Text = idHAck.ToString();
            if (type == "atelier")
            {
                tbx_heureEvent.Visible = true;
                tbx_NomSalle.Visible = true;
                lbl_dateEvent.Visible = true;
                lbl_duree.Visible = true;
                lbl_place.Visible = true;
                lbl_salle.Visible = true;
                champ_Duree.Visible = true;
                champDateEvent.Visible = true;
                champ_nbPlace.Visible = true;
                btn_atelier.Visible = true;
                lbl_themeConference.Visible = false;
                lbl_nomIntervenant.Visible = false;
                tbx_themeConference.Visible = false;
                tbx_nomIntervenant.Visible = false;
                btn_conférence.Visible = false;
            }
            else if (type == "conférence")
            {
                lbl_themeConference.Visible = true;
                lbl_nomIntervenant.Visible = true;
                tbx_nomIntervenant.Visible = true;
                btn_conférence.Visible = true;
                tbx_heureEvent.Visible = true;
                tbx_NomSalle.Visible = true;
                lbl_dateEvent.Visible = true;
                lbl_duree.Visible = true;
                lbl_place.Visible = false;
                lbl_salle.Visible = true;
                champDateEvent.Visible = true;
                champ_Duree.Visible = true;
                champ_nbPlace.Visible = true;
                btn_atelier.Visible = false;
                lbl_heureEvent.Visible = true;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_conférence_Click(object sender, EventArgs e)
        {
            Eventconference uneConference = new Eventconference
            {
                Theme = tbx_themeConference.Text,
                Intervenant = tbx_nomIntervenant.Text,
                Dateevent = champDateEvent.Value,
                Heureevent = tbx_heureEvent.Text,
                Nomsalle = tbx_NomSalle.Text,
                Mailintervenant = tbx_MailIntervenant.Text,
                Dureeevent = Convert.ToInt32(champ_Duree.Text),
                Idhack = Convert.ToInt32(lbl_id.Text),

            };
            cnx.Eventconferences.Add(uneConference);
            cnx.SaveChanges();
        }

        private void btn_atelier_Click(object sender, EventArgs e)
        {

            Eventatelier unAtelier = new Eventatelier
            {
                Nbparticipants = Convert.ToInt32(champ_nbPlace.Text),
                Dateevent = champDateEvent.Value,
                Heureevent = tbx_heureEvent.Text,
                Nomsalle = tbx_NomSalle.Text,
                Dureeevent = Convert.ToInt32(champ_Duree.Text),
                Idhack = Convert.ToInt32(lbl_id.Text),

            };

            cnx.Eventateliers.Add(unAtelier);
            cnx.SaveChanges();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}

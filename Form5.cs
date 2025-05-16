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

namespace HackatonLourd
{
    public partial class Form5 : Form
    {
        ArasoharimalalaHackatContext cnx = new ArasoharimalalaHackatContext();
        public Form5()
        {
            InitializeComponent();

        }
        private void LoadHackaton()
        {
            loadHackaton();
        }
        public void loadHackaton()
        {
            cbx_hackaton.SelectedIndexChanged -= cbx_hackaton_SelectedIndexChanged;
            cbx_hackaton.DataSource = cnx.Hackatons.Include(h => h.Eventateliers).OrderBy(cli => cli.Themehack).ToList();
            cbx_hackaton.DisplayMember = "THEMEHACK";
            cbx_hackaton.ValueMember = "IDHACK";
            cbx_hackaton.SelectedIndexChanged += cbx_hackaton_SelectedIndexChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadHackaton();
        }

        private void cbx_hackaton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_hackaton.SelectedItem != null)
            {
                Hackaton unHackaton = (Hackaton)cbx_hackaton.SelectedItem;
                tbx_theme.Text = unHackaton.Themehack;
                tbx_ville.Text = unHackaton.Villehack;
                tbx_rue.Text = unHackaton.Ruehack;
                tbx_heureDebut.Text = unHackaton.Heuredebuthack;
                tbx_heureFin.Text = unHackaton.Heurefinhack;
                textBox1.Text = unHackaton.Nbplaceshack.ToString();
                tbx_codePostal.Text = unHackaton.Cphack;
                dateDebut.Value = Convert.ToDateTime(unHackaton.Datedebuthack);
                dateLimite.Value = Convert.ToDateTime(unHackaton.Datelimitehack);
                dateFin.Value = Convert.ToDateTime(unHackaton.Datefinhack);

            }

        }

        private void btn_ajouHackaton_Click(object sender, EventArgs e)
        {
            try
            {
                Hackaton hackaton = new Hackaton
                {
                    Themehack = tbx_theme.Text,
                    Ruehack = tbx_rue.Text,
                    Cphack = tbx_codePostal.Text,
                    Villehack = tbx_ville.Text,
                    Datedebuthack = dateDebut.Value,
                    Datefinhack = dateFin.Value,
                    Datelimitehack = dateLimite.Value,
                    Heuredebuthack = tbx_heureDebut.Text,
                    Heurefinhack = tbx_heureFin.Text,
                    Nbplaceshack = int.TryParse(textBox1.Text, out int nbPlaces) ? nbPlaces : 0,
                };

                cnx.Hackatons.Add(hackaton);
                cnx.SaveChanges();

                MessageBox.Show("Hackathon ajouté avec succès !");
                LoadHackaton(); // Rafraîchir la liste des hackathons
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modifierHackaton_Click(object sender, EventArgs e)
        {
            if (cbx_hackaton.SelectedItem is Hackaton hackaton)
            {
                try
                {
                    hackaton.Themehack = tbx_theme.Text;
                    hackaton.Ruehack = tbx_rue.Text;
                    hackaton.Cphack = tbx_codePostal.Text;
                    hackaton.Villehack = tbx_ville.Text;
                    hackaton.Datedebuthack = dateDebut.Value;
                    hackaton.Datefinhack = dateFin.Value;
                    hackaton.Datelimitehack = dateLimite.Value;
                    hackaton.Heuredebuthack = tbx_heureDebut.Text;
                    hackaton.Heurefinhack = tbx_heureFin.Text;
                    hackaton.Nbplaceshack = int.TryParse(textBox1.Text, out int nbPlaces) ? nbPlaces : 0;

                    cnx.SaveChanges();

                    MessageBox.Show("Hackathon modifié avec succès !");
                    LoadHackaton(); // Rafraîchir la liste des hackathons
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un hackathon à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_supprimerHackaton_Click(object sender, EventArgs e)
        {
            if (cbx_hackaton.SelectedItem is Hackaton hackaton)
            {
                var rep = MessageBox.Show("Voulez-vous vraiment supprimer ce hackathon ?",
                                          "Attention !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                Eventatelier eventatelier = new Eventatelier();
                if (rep == DialogResult.OK)
                {

                    //Suppression des événements liés au hackathon


                    var leHackathon = cnx.Hackatons.Include(h => h.Eventateliers).FirstOrDefault(h => h.Idhack == hackaton.Idhack);
                    var ConferenceToDelete = cnx.Eventconferences.Where(e => e.Idhack == hackaton.Idhack).ToList();

                    var ateliersToDelete = cnx.Eventateliers.Where(e => e.Idhack == hackaton.Idhack).ToList();

                    foreach (var conference in hackaton.Eventconferences)
                    {
                        string timeAsString = conference.Dureeevent.ToString();
                        cnx.Eventconferences.Remove(conference);

                    }

                    foreach (var atelier in hackaton.Eventateliers)
                    {

                        string timeAsString = atelier.Dureeevent.ToString();
                        cnx.Eventateliers.Remove(atelier);

                    }
                    foreach (var inscription in hackaton.Inscriptions)
                    {
                        cnx.Inscriptions.Remove(inscription);
                    }
                    // Suppression du hackathon
                    cnx.Hackatons.Remove(hackaton);

                    // Sauvegarde des changements
                    cnx.SaveChanges();

                    MessageBox.Show("Hackathon et ses événements liés supprimés avec succès !");
                    LoadHackaton(); // Rafraîchir la liste des hackathons


                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un hackathon à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ajoutAteliers_Click(object sender, EventArgs e)
        {
            if (cbx_hackaton.SelectedValue != null)
            {
                int selectedId = (int)cbx_hackaton.SelectedValue;
                Form2 secondForm = new Form2(selectedId, "atelier");
                secondForm.Show();
                this.Hide();
            }
        }

        private void btn_ajoutConference_Click(object sender, EventArgs e)
        {
            if (cbx_hackaton.SelectedValue != null)
            {
                int selectedId = (int)cbx_hackaton.SelectedValue;
                Form2 secondForm = new Form2(selectedId, "conférence");
                secondForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}

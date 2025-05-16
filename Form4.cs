using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackatonLourd.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
//using MailKit.Net.Smtp;
using MimeKit;
using MailKit;
using System.Net.Mail;
using System.Net;


namespace HackatonLourd
{
    public partial class Form4 : Form
    {

        ArasoharimalalaHackatContext cnx = new ArasoharimalalaHackatContext();
        public Form4()
        {
            InitializeComponent();

        }

        private void LoadEventConferenceInNextWeek()
        {

        }

        private void liste_eventConference_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            liste_eventConference.DataSource = cnx.Eventconferences.Where(e => Convert.ToInt32(e.Dateevent.Value.Day) - DateTime.Now.Day >= 7).ToList();
            //liste_eventConference.DataSource = cnx.Eventconferences.ToList();
            liste_eventConference.ValueMember = "Theme";
        }

        private void btn_envoi_mail_Click(object sender, EventArgs e)
        {
            // Dictionnaire pour suivre les événements ayant déjà eu un email envoyé
            Dictionary<int, bool> emailSentForEvent = new Dictionary<int, bool>();

            if (liste_eventConference.SelectedIndex != null)
            {
                Eventconference unevent = (Eventconference)liste_eventConference.SelectedItem;



                try
                {
                    string smtpServer = "smtp.gmail.com";
                    int smtpPort = 25; // Correct port for STARTTLS

                    string senderEmail = "alexloic501@gmail.com";
                    string senderPassword = "atrs qgmv ereg iipr";
                    string recipientEmail = unevent.Mailintervenant;

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Hackaton qui vont venir dans une semaines";
                    mail.Body = "Bonjour monsieur ou Madame " + unevent.Intervenant +
                                ", je tenais à vous rappeler que l'événement sur " +
                                unevent.Theme + " se déroulera le " + unevent.Dateevent +
                                " à " + unevent.Heureevent;
                    mail.IsBodyHtml = true;

                    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mail);

                    MessageBox.Show("Le mail a été envoyé", "Succès", MessageBoxButtons.OK);


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur : " + ex.Message);
                }
            }



        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string smtpServer = "smtp.gmail.com";
            //    int smtpPort = 25; // 465 pour SSL

            //    string senderEmail = "alexloic501@gmail.com";
            //    string senderPassword = "atrs qgmv ereg iipr";
            //    string recipientEmail = "randriajordy8@gmail.com";

            //    MailMessage mail = new MailMessage();
            //    mail.From = new MailAddress(senderEmail);
            //    mail.To.Add(recipientEmail);
            //    mail.Subject = "Test SMTP Gmail";
            //    mail.Body = "Ceci est un test d'envoi d'email via SMTP Gmail en C#. ";
            //    mail.IsBodyHtml = true; // Permet d'envoyer du HTML

            //    SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            //    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            //    smtpClient.EnableSsl = true; // Sécuriser la connexion

            //    smtpClient.Send(mail);
            //    Console.WriteLine("E-mail envoyé avec succès !");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erreur : " + ex.Message);
            //}

            //MailMessage message = new MailMessage("alexloic501@gmail.com", "randriajordy8@gmail.com", "test envoie de mail", "I see u baby boiiii");
            //SmtpClient client = new SmtpClient("smtp.gmail.com");
            //client.Port = 25;
            //client.Credentials = new System.Net.NetworkCredential("alexloic501@gmail.com", "atrs qgmv ereg iipr");
            //client.EnableSsl = true;
            //client.Send(message);
            //MessageBox.Show("Le mail est envoyé", "success", MessageBoxButtons.OK);
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();    
        }
    }

}

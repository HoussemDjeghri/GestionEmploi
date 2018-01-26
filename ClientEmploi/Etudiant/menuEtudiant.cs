using Bunifu.Framework.UI;
using EmploiDuTempsDLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClientEmploi.CommunFuctions;
namespace ClientEmploi
{
    public partial class menuEtudiant : Form
    {
        IEtudiant obj;
        public menuEtudiant(IEtudiant obj)
        {
            this.obj = obj;
            InitializeComponent();
            prenomLabel.Text = loginForm.user.prenom;
            
            emploiEtudiant emploietud = new emploiEtudiant();
            ArrayList emploi = obj.acceder_emploi(loginForm.user.id_utilisateur);
            ViderEmploi(emploietud.getEmploi());
            for (int ligne = 1; ligne <= 5; ligne++)
            {

                for (int colomne = 1; colomne <= 5; colomne++)
                {
                    int cr = (ligne * 5) - (5 - colomne);
                    foreach (EmploiObj item in emploi)
                    {

                        if (item.id_creaneau == cr)
                        {

                            BunifuThinButton2 bc = null;
                            switch (item.type)
                            {
                                case "amphi":
                                    bc = CreerCourBtn(item.module, item.salle);

                                    break;
                                case "td":
                                    bc = CreerTDBtn(item.module, item.salle);
                                    break;
                                case "tp":
                                    bc = CreerTPBtn(item.module, item.salle);
                                    break;
                                default:
                                    break;
                            }

                            if (bc != null) { emploietud.AddToEmploiPanel(bc, ligne, colomne); }







                        }


                    }

                }



            }


            emploietud.TopLevel = false;
            emploietud.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(emploietud);
            emploietud.Show();

        }

        private void titleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          
            ArrayList emploi = obj.acceder_emploi(loginForm.user.id_utilisateur);

            emploiEtudiant emploietud = new emploiEtudiant();
            ViderEmploi(emploietud.getEmploi());
           
            for (int ligne = 1; ligne <=5 ; ligne++)
            {
               
                for (int colomne = 1; colomne <= 5; colomne++)
                {
                    int cr = (ligne * 5) - (5 - colomne);
                    foreach (EmploiObj item in emploi)
                    {
                       
                        if (item.id_creaneau == cr) {

                            BunifuThinButton2 bc=null;
                            switch (item.type)
                            {
                                case "amphi":
                                 bc = CreerCourBtn(item.module, item.salle);
                                   
                                    break;
                                case "td":
                                 bc = CreerTDBtn(item.module, item.salle);
                                    break;
                                case "tp":
                                 bc = CreerTPBtn(item.module, item.salle);
                                    break;
                                default:
                                    break;
                            }
                           

                            if (bc != null) { emploietud.AddToEmploiPanel(bc, ligne, colomne); }
                           






                        }


                    }
                    
                }



            }

           
            emploietud.TopLevel = false;
            emploietud.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(emploietud);
            emploietud.Show();













        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            // do this to unregister the channel
            IChannel[] regChannels = ChannelServices.RegisteredChannels;
            IChannel channel = (IChannel)ChannelServices.GetChannel(regChannels[0].ChannelName);

            ChannelServices.UnregisterChannel(channel);


            loginForm log = new loginForm();

            this.Hide();
            log.Closed += (s, args) => this.Close();
            log.Show();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilBtn_Click(object sender, EventArgs e)
        {
            profil listenForm = new profil(loginForm.obj);
            listenForm.Show();
        }
    }
}

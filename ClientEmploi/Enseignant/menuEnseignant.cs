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
    public partial class menuEnseignant : Form
    {
         IEnseignant obj;
         NotificationClass objNotif;
         ArrayList emploi;
        public static dashboardEnseignant emp;

        public menuEnseignant(IEnseignant obj )
        {
            this.obj = obj;
            InitializeComponent();
            emp = new dashboardEnseignant(obj);

            objNotif = (NotificationClass)Activator.GetObject(typeof(NotificationClass), "tcp://localhost:1235/ObjNotification");

            // Create a proxy from remote object.
            //Create an instance of wrapper class.
            NotifWrapper notifWrapper = new NotifWrapper();

            //Associate remote object event with wrapper method.
            objNotif.EmploiChanged += new EmploiChangedEvent(notifWrapper.WrapperNotificationReceivedHandler);
            //Associate wrapper event with current form event handler.
            notifWrapper.WrapperNotificationReceived += new EmploiChangedEvent(NotificationReceivedHandler);




            
            prenomLabel.Text = loginForm.user.prenom;
            emp.TopLevel = false;
            emp.AutoScroll = false;
            container.Controls.Clear();
            container.Controls.Add(emp);
            emp.Show();


        }


        public void NotificationReceivedHandler(int id_en,string message)
        {
            ListView notifborad = emp.getNotifBoard();
            if (notifborad.InvokeRequired == false)
            {
                if (loginForm.user.id_utilisateur == id_en)
                {
                    notifborad.Items.Add(message);
                    MessageBox.Show(message);
                }
            }
            else
            {
                // Show the text asynchronously
                EmploiChangedEvent statusDelegate =
                   new EmploiChangedEvent(crossThreadEventHandler);
                this.BeginInvoke(statusDelegate,
                  new object[] {  id_en, message });
            }

        }

        private void crossThreadEventHandler(int id_en ,string message)
        {
              if (loginForm.user.id_utilisateur == id_en)
              {
                  emp.getNotifBoard().Items.Add(message);
                  MessageBox.Show(message);
              }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            emploiEnseignant emp = new emploiEnseignant();
            ToolTip toolTip1 = new ToolTip();
            emploi = obj.Acceder_emploi(loginForm.user.id_utilisateur);

            ViderEmploi(emp.get_emploi());
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
                                    bc = CreerCourBtn(item.module, item.salle,item.section);

                                    break;
                                case "td":
                                    bc = CreerTDBtn(item.module, item.salle,item.group);
                                    break;
                                case "tp":
                                    bc = CreerTPBtn(item.module, item.salle,item.group);
                                    break;
                                default:
                                    break;
                            }

                            if (bc != null) {



                                emp.AddToEmploiPanel(bc, colomne, ligne,item.id_seance); }
                                                           






                        }


                    }

                }



            }



    





            emp.TopLevel = false;
            emp.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(emp);
            emp.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            listeEtudiant emp = new listeEtudiant(obj);
            emp.TopLevel = false;
            emp.AutoScroll = false;
            container.Controls.Clear();
            container.Controls.Add(emp);
            emp.Show();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
           
            emp.TopLevel = false;
            emp.AutoScroll = false;
            container.Controls.Clear();
            container.Controls.Add(emp);
            emp.Show();

           

           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            profil listenForm = new profil(loginForm.obj);
            listenForm.Show();
        }
        public void OnEmploiChanged(int id_en , String notif)
        {

            if (loginForm.user.id_utilisateur == id_en)
            {

                MessageBox.Show(notif);

            }

        }
    }
}

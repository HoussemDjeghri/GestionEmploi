using EmploiDuTempsDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientEmploi
{
    public partial class menuScolarite : Form
    {
        IScolarite obj;
        public menuScolarite(IScolarite obj)
        {
          
            this.obj = obj;
            InitializeComponent();
            prenomLabel.Text = loginForm.user.prenom;
            dashboardScolarite emp = new dashboardScolarite(obj);
            emp.TopLevel = false;
            emp.AutoScroll = false;
            container.Controls.Clear();
            container.Controls.Add(emp);
            emp.Show();
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
           gestionEmploiFom emp = new gestionEmploiFom(obj);
            emp.TopLevel = false;
            emp.AutoScroll = true;
            container.Controls.Clear();
           container.Controls.Add(emp);
            emp.Show();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            listeEtudiantSco listetFrom = new listeEtudiantSco(obj);
            listetFrom.TopLevel = false;
            listetFrom.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(listetFrom);
            listetFrom.Show();


        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            listeEnseignantSco listenForm = new listeEnseignantSco(obj);
            listenForm.TopLevel = false;
            listenForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(listenForm);
            listenForm.Show();
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

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            dashboardScolarite listenForm = new dashboardScolarite(obj);
            listenForm.TopLevel = false;
            listenForm.AutoScroll = true;
            container.Controls.Clear();
            container.Controls.Add(listenForm);
            listenForm.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            profil listenForm = new profil(loginForm.obj);
            listenForm.Show();
        }
    }
}

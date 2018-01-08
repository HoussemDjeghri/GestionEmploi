
using ServeurEmploi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeurEmploi
{
    public partial class Form1 : Form
    {
        Boolean etatServeur = false;
        TcpChannel chnl;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (etatServeur)
            {

                if (chnl != null)
                {
                    ChannelServices.UnregisterChannel(chnl);
                    pbox.ImageLocation = "E:/on.png";
                    label1.Text = "Serveur OFF";
                  
                    etatServeur = false;
                }


            }
            else
            {

                 chnl = new TcpChannel(1235);

                ChannelServices.RegisterChannel(chnl, false);

                RemotingConfiguration.RegisterWellKnownServiceType(typeof(IEtudiantImpl), "ObjEtudiant", WellKnownObjectMode.SingleCall);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(IEnseignantImpl), "ObjEnseignant", WellKnownObjectMode.SingleCall);

                pbox.ImageLocation = "E:/off.png";
                label1.Text = "Serveur ON";
                
                etatServeur = true;

            }



            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

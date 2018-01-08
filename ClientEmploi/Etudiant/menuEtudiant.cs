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
        public menuEtudiant()
        {
            TcpChannel chnl = new TcpChannel();

            ChannelServices.RegisterChannel(chnl, false);

            Console.WriteLine("Client : Canal Enregistré");
            obj = (IEtudiant)Activator.GetObject(typeof(IEtudiant), "tcp://localhost:1235/ObjEtudiant");
            if (obj == null)
            {
                Console.WriteLine("Problem du Serveur");


            }
            else
            {

                Console.WriteLine("Reference Aquise avec succés");

            }

            Console.WriteLine("Serveur Démarré");


            InitializeComponent();


            emploiEtudiant emploietud = new emploiEtudiant();

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
          
            ArrayList emploi = obj.acceder_emploi(3001);

            emploiEtudiant emploietud = new emploiEtudiant();

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



     

    }
}

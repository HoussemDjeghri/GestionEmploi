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
         ArrayList emploi;
        public menuEnseignant()
        {
           TcpChannel chnl = new TcpChannel();

            ChannelServices.RegisterChannel(chnl, false);

            Console.WriteLine("Client : Canal Enregistré");
            obj = (IEnseignant)Activator.GetObject(typeof(IEnseignant), "tcp://localhost:1235/ObjEnseignant");
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
            dashboardEnseignant emp = new dashboardEnseignant();
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
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            emploiEnseignant emp = new emploiEnseignant();
            ToolTip toolTip1 = new ToolTip();
            emploi = obj.acceder_emploi(2001);

        
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
                                    bc = CreerCourBtn(item.module, item.salle, item.group);

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



                                emp.AddToEmploiPanel(bc, colomne, ligne); }
                                                           






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
            listeEtudiant emp = new listeEtudiant();
            emp.TopLevel = false;
            emp.AutoScroll = false;
            container.Controls.Clear();
            container.Controls.Add(emp);
            emp.Show();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            dashboardEnseignant emp = new dashboardEnseignant();
            emp.TopLevel = false;
            emp.AutoScroll = false;
            container.Controls.Clear();
            container.Controls.Add(emp);
            emp.Show();

           

           
        }
    }
}

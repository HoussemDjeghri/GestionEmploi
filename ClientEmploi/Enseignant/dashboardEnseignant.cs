using EmploiDuTempsDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientEmploi
{
    public partial class dashboardEnseignant : Form
    {
        IEnseignant obj;
        public dashboardEnseignant(IEnseignant obj)
        {
            InitializeComponent();



            double vh = obj.acceder_volumeHoraire(loginForm.user.id_utilisateur);
            vhLabel.Text = vh+" H/S";
            int nombre_cours = obj.acceder_nombre_cours(loginForm.user.id_utilisateur);
            nbrCourslbl.Text = nombre_cours.ToString();
            int nombre_td_tp = obj.acceder_nombre_td_tp(loginForm.user.id_utilisateur);
            nbrTDTPLbl.Text = nombre_td_tp.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void dashboardEnseignant_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        public ListView getNotifBoard()
        {
            return notifList;


        }
    }
}
